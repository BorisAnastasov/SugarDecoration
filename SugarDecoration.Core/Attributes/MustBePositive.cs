using System.ComponentModel.DataAnnotations;

namespace SugarDecoration.Core.Attributes
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class MustBePositive : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			if (decimal.Parse(value.ToString())<=0) 
			{
				return false;
			}

			return true;
		}
	}
}
