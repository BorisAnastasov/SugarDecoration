using Microsoft.AspNetCore.Identity;

namespace SugarDecoration.Infrastructure.Data.IdentityModels
{
	public class ApplicationRole : IdentityRole
    {
        public string BGName { get; set; } = string.Empty;
    }
}
