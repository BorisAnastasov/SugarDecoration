using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SugarDecoration.Core.Services;
using SugarDecoration.Infrastructure.Data;
using SugarDecoration.Infrastructure.Data.Contracts;
namespace SugarDecoration.UnitTests
{
	public class CakeServiceTests
	{
		private IRepository repository;
		private ILogger<CakeService> logger;
		private CakeService cakeService;
		private SugarDecorationDb context;

		[SetUp]
		public void Setup()
		{
			var contextOptions = new DbContextOptionsBuilder<SugarDecorationDb>().UseInMemoryDatabase("SugarDecorationDb").Options;

			context = new SugarDecorationDb(contextOptions);

			context.Database.EnsureDeletedAsync();
			context.Database.EnsureCreatedAsync();
		}










		[TearDown]
		public void TearDown()
		{
			context.Dispose();
		}
	}
}
