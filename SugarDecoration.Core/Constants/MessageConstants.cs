using SugarDecoration.Infrastructure.Data.Constants;

namespace SugarDecoration.Core.Constants
{
	public static class MessageConstants
    {
        public const string RequiredMessage = "The {0} field is required";

        public const string LengthMessage = "The field {0} must be between {2} and {1} characters long";

        public const string InvalidDecimal = "The field must be greater than or equal to zero.";

        public const string InvalidCategory = "Category does not exist";

        public const string InvalidDateTimeFormat = "Invalid date! Format must be: dd/MM/yyyy";


    }
}
