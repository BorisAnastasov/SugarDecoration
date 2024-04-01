using System.ComponentModel.DataAnnotations;

namespace SugarDecoration.Core.Attributes
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class MustBePositive : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			if (value == null)
			{
				return true; // Let RequiredAttribute handle this case
			}

			if (value is int intValue)
			{
				return intValue >= 0;
			}

			if (value is double doubleValue)
			{
				return doubleValue >= 0;
			}

			if (value is decimal decimalValue)
			{
				return decimalValue >= 0;
			}

			if (value is float floatValue)
			{
				return floatValue >= 0;
			}

			return false; // if it's not a supported numeric type
		}
	}
}
