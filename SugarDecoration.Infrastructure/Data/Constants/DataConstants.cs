namespace SugarDecoration.Infrastructure.Constants
{
	public static class DataConstants
	{
		public static class Product 
		{
			public const int TitleMaxLength = 100;
			public const int TitleMinLength = 5;

			public const int RatingMax = 5;
			public const int RatingMin = 1;

			public const int ImageUrlMaxLength = 1000;
		}

		public static class Cake
		{
			public const int LayersMax = 5;
			public const int LayersMin = 1;

			public const int FormMaxLength = 30;
			public const int FormMinLength = 3;

			public const int PortionsMax = 100;
			public const int PortionsMin = 5;
		}

		public static class Category 
		{
			public const int NameMaxLength = 30; 
			public const int NameMinLength = 3; 
        }

		public static class ApplicationUser
		{
			public const int FirstNameMaxLength = 20;
			public const int LastNameMaxLength = 30;
		}

		public static class Review 
		{
			public const int RatingMax = 5;
			public const int RatingMin = 1;

			public const int CommentMaxLength = 100;
			public const int CommentMinLength =3;
		}
	}
}
