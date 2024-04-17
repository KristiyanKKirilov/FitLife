using FitLife.Data;
using Microsoft.EntityFrameworkCore;

namespace FitLife.Tests.Mocks
{
	public static class DatabaseMock
	{
		public static FitLifeDbContext Instance
		{
			get
			{
				var dbContextOptions = new DbContextOptionsBuilder<FitLifeDbContext>()
					.UseInMemoryDatabase("FitLifeInMemoryDb"
						+ Guid.NewGuid().ToString()).Options;

				return new FitLifeDbContext(dbContextOptions);
			}
		}
	}
}
