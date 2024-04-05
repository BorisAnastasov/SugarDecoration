using SugarDecoration.Core.Contracts;
using SugarDecoration.Infrastructure.Data.Contracts;
using SugarDecoration.Infrastructure.Data.Models.Account;

namespace SugarDecoration.Core.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly IRepository repository;

        public ApplicationUserService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<string> UserFullName(string userId)
        {
            var user = await repository.GetByIdAsync<ApplicationUser>(userId);


            if (string.IsNullOrEmpty(user.FirstName)|| string.IsNullOrEmpty(user.LastName)) 
            {
                return null;
            }

            return user.FirstName +" " + user.LastName;
        }
    }
}
