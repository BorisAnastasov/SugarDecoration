using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.ApplicationUser;

namespace SugarDecoration.Infrastructure.Data.Models.Account
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;
    }
}
