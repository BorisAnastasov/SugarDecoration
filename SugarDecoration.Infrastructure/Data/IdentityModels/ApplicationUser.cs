using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static SugarDecoration.Infrastructure.Constants.DataConstants.ApplicationUser;

namespace SugarDecoration.Infrastructure.Data.IdentityModels
{
    public class ApplicationUser : IdentityUser<int>
    {
        [StringLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = string.Empty;

        [StringLength(LastNameMaxLength)]
        public string LastName { get; set; } = string.Empty;

    }
}
