using FitLife.Web.ViewModels.Event;

namespace FitLife.Web.Areas.Admin.Models.Event
{
    public class MyEventViewModel
    {
        public MyEventViewModel()
        {
            AddedEvents = new List<EventServiceModel>();
            JoinedEvents = new List<EventServiceModel>();
        }

        public IEnumerable<EventServiceModel> AddedEvents { get; set; }

        public IEnumerable<EventServiceModel> JoinedEvents { get; set; }
    }
}

