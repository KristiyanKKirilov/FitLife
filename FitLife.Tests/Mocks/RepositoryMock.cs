using FitLife.Data.Common;
using FitLife.Data.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitLife.Tests.Mocks
{
	public static class RepositoryMock
	{
		public static IRepository Create()
		{
			var mockRepository = new Mock<IRepository>();

			mockRepository.Setup(repo => repo.AddAsync(It.IsAny<object>()))
				.Returns(Task.CompletedTask);

			mockRepository.Setup(repo => repo.All<TrainingProgram>())
				.Returns(new List<TrainingProgram>().AsQueryable());

			mockRepository.Setup(repo => repo.AllReadOnly<TrainingProgram>())
				.Returns(new List<TrainingProgram>().AsQueryable());

			mockRepository.Setup(repo => repo.GetByIdAsync<TrainingProgram>(It.IsAny<object>()))
				.Returns(Task.FromResult<TrainingProgram>(null));

			mockRepository.Setup(repo => repo.Remove(It.IsAny<object>()));

			mockRepository.Setup(repo => repo.SaveChangesAsync())
				.Returns(Task.FromResult(0));

			return mockRepository.Object;
		}
	}
}
