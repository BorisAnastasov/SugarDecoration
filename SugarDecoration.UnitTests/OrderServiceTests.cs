using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Contracts.Admin;
using SugarDecoration.Infrastructure.Data;

namespace SugarDecoration.UnitTests
{
    [TestFixture]
    public class OrderServiceTests
    {
        private IBiscuitService biscuitService;
        private IAdminBiscuitService biscuitServiceAdmin;

        private SugarDecorationDb context;

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<SugarDecorationDb>().UseInMemoryDatabase("SugarDecorationDb1").Options;

            context = new SugarDecorationDb(contextOptions);

            context.Database.EnsureDeletedAsync();
            context.Database.EnsureCreatedAsync();
        }



    }
}
