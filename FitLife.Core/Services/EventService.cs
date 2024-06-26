﻿using FitLife.Core.Contracts;
using FitLife.Data.Common;
using FitLife.Data.Models;
using FitLife.Data.Models.Enumerations;
using FitLife.GlobalConstants;
using FitLife.Web.ViewModels.Event;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace FitLife.Core.Services
{
    public class EventService : IEventService
    {
        private readonly IRepository repository;

        public EventService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<EventQueryServiceModel> AllAsync(
            string? userCity,
            string? category = null,
            string? searchTerm = null,
            EventSorting sorting = EventSorting.MostRecent,
            int currentPage = 1,
            int eventsPerPage = 1)

        {
            var eventsToShow = repository.AllReadOnly<Event>();

            if (category != null)
            {
                eventsToShow = eventsToShow
                    .Where(h => h.Category.Name == category);
            }

            if (searchTerm != null)
            {
                string normalizedSearchTerm = searchTerm.ToLower();

                eventsToShow = eventsToShow
                    .Where(e => e.Title.ToLower().Contains(normalizedSearchTerm)
                            || e.Address.ToLower().Contains(normalizedSearchTerm)
                            || e.Description.ToLower().Contains(normalizedSearchTerm)
                            || e.City.ToLower().Contains(normalizedSearchTerm));
            }

            eventsToShow = sorting switch
            {
                EventSorting.UpComingEvents => eventsToShow
                    .OrderByDescending(h => h.StartTime),
                EventSorting.EventsInYourTownFirst => eventsToShow
                    .OrderBy(e => e.City != userCity)
                    .ThenBy(h => h.StartTime),
                _ => eventsToShow
                .OrderBy(h => h.StartTime)
            };

            var events = await eventsToShow
                .Skip((currentPage - 1) * eventsPerPage)
                .Take(eventsPerPage)
                .ProjectToEventServiceModel()
                .ToListAsync();

            int totalEvents = await eventsToShow.CountAsync();

            return new EventQueryServiceModel()
            {
                TotalEventsCount = totalEvents,
                Events = events
            };
        }

        public async Task<IEnumerable<EventCategoryServiceModel>> AllCategoriesAsync()
        {
            return await repository
                .All<EventCategory>()
                .Select(ec => new EventCategoryServiceModel()
                {
                    Id = ec.Id,
                    Name = ec.Name
                }).ToListAsync();
        }

        public async Task<IEnumerable<string>> AllCategoriesNamesAsync()
        {
            return await repository
                .AllReadOnly<EventCategory>()
                .Select(ec => ec.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<IEnumerable<EventServiceModel>> AllEventsByParticipantAsync(string participantId)
        {
            return await repository
                .AllReadOnly<Event>()
                .Include(e => e.ParticipantsEvents)
                .Where(e => e.ParticipantsEvents.Any(pe => pe.ParticipantId == participantId))
                .ProjectToEventServiceModel()
                .ToListAsync();
        }

        public async Task<IEnumerable<EventServiceModel>> AllEventsByTrainerAsync(string trainerId)
        {
            return await repository
                .AllReadOnly<Event>()
                .Where(e => e.CreatorId == trainerId)
                .ProjectToEventServiceModel()
                .ToListAsync();
        }

        public async Task<bool> CategoryExistsAsync(int categoryId)
        {
            return await repository
                .AllReadOnly<EventCategory>()
                .AnyAsync(e => e.Id == categoryId);
        }

        public async Task<string> CreateAsync(EventFormModel model, string trainerId)
        {
            var date = DateTime.Now;


            if (!DateTime.TryParseExact(model.StartTime, "dd/MM/yyyy hh:mm",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out date))
            {
                throw new ArgumentException();
            }

            var newEvent = new Event()
            {
                Title = model.Title,
                StartTime = date,
                Address = model.Address,
                CategoryId = model.CategoryId,
                City = model.City,
                Description = model.Description,
                CreatorId = trainerId,
                ImageUrl = model.ImageUrl
            };

            await repository.AddAsync(newEvent);
            await repository.SaveChangesAsync();

            return newEvent.Id;
        }

        public async Task DeleteAsync(string eventId)
        {
            var currentEvent = await repository
                 .GetByIdAsync<Event>(eventId);

            if (currentEvent != null)
            {
                repository.Remove(currentEvent);
                await repository.SaveChangesAsync();
            }
        }

        public async Task<EventDetailsServiceModel> EventDetailsByIdAsync(string eventId)
        {
            return await repository
                .AllReadOnly<Event>()
                .Where(e => e.Id == eventId)
                .Select(e => new EventDetailsServiceModel()
                {
                    Id = e.Id,
                    Title = e.Title,
                    Address = e.Address,
                    CategoryName = e.Category.Name,
                    Description = e.Description,
                    City = e.City,
                    StartTime = e.StartTime,
                    CreatorEmail = e.Creator.Email,
                    CreatorName = e.Creator.FirstName + " " + e.Creator.LastName,
                    ImageUrl = e.ImageUrl
                }).FirstAsync();
        }

        public async Task<bool> ExistsAsync(string eventId)
        {
            return await repository
                .AllReadOnly<Event>()
                .AnyAsync(e => e.Id == eventId);
        }

        public async Task<EventModifyModel?> GetEventModifyModelByIdAsync(string eventId)
        {
            var currentEvent = await repository
                .AllReadOnly<Event>()
                .Where(e => e.Id == eventId)
                .Select(e => new EventModifyModel()
                {
                    Id = e.Id,
                    StartTime = e.StartTime.ToString(DataConstants.DateFormat),
                    Address = e.Address,
                    City = e.City,
                    ImageUrl = e.ImageUrl,
                    CategoryId = e.Category.Id,
                    Description = e.Description,
                    Title = e.Title
                }).FirstOrDefaultAsync();

            if (currentEvent != null)
            {
                currentEvent.EventCategories = await AllCategoriesAsync();
            }

            return currentEvent;
        }

        public async Task<bool> HasParticipantWithIdAsync(string eventId, string participantId)
        {
            var events = await repository
            .AllReadOnly<Event>()
                .Where(e => e.Id == eventId)
                .Include(e => e.ParticipantsEvents)
                .FirstOrDefaultAsync();
            if (events != null)
            {
                if (events.ParticipantsEvents
                .Any(tp => tp.ParticipantId == participantId && tp.EventId == eventId))
                {
                    return true;
                }
            }

            return false;
        }

        public async Task<bool> HasTrainerWithIdAsync(string eventId, string userId)
        {
            return await repository
            .AllReadOnly<Event>()
                .AnyAsync(tp => tp.Id == eventId && tp.Creator.UserId == userId);
        }

        public async Task ModifyAsync(string eventId, EventModifyModel model)
        {
            var currentEvent = await repository
                .GetByIdAsync<Event>(eventId);

            var date = DateTime.Now;

            if (!DateTime.TryParseExact(
                model.StartTime,
                DataConstants.DateFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out date))
            {
                throw new Exception();
            }

            if (currentEvent != null)
            {
                currentEvent.Title = model.Title;
                currentEvent.Description = model.Description;
                currentEvent.Address = model.Address;
                currentEvent.City = model.City;
                currentEvent.ImageUrl = model.ImageUrl;
                currentEvent.CategoryId = model.CategoryId;
                currentEvent.StartTime = date;

                await repository.SaveChangesAsync();
            }
        }

        public async Task JoinAsync(string eventId, string userId)
        {
            var currentEvent = await repository
                .GetByIdAsync<Event>(eventId);

            if (currentEvent != null)
            {
                currentEvent.ParticipantsEvents.Add(new ParticipantEvent()
                {
                    ParticipantId = userId,
                    EventId = eventId
                });

                await repository.SaveChangesAsync();

            }
        }
    }
}
