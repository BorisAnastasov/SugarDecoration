﻿using System.ComponentModel.DataAnnotations;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.ApplicationUser;

namespace SugarDecoration.Core.Models.Account
{
	public class RegisterViewModel
	{
		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public string Email { get; set; } = string.Empty;

		[Required]
		[Display(Name = "First Name")]
		[StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
		public string FirstName { get; set; } = string.Empty;

		[Required]
		[Display(Name = "Last Name")]
		[StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
		public string LastName { get; set; } = string.Empty;

		[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; } = string.Empty;

		[DataType(DataType.Password)]
		[Display(Name = "Confirm password")]
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; } = string.Empty;
	}
}
