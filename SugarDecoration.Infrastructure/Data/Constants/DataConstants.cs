namespace SugarDecoration.Infrastructure.Data.Constants
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
			public const int ImageUrlMinLength = 0;

            public const string DateTimeFormat = "dd.MM.yyyy HH:mm";
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
			public const int FirstNameMaxLength = 50;
			public const int FirstNameMinLength = 2;

			public const int LastNameMaxLength = 50;
			public const int LastNameMinLength = 2;
        }

		public static class Review 
		{
			public const int RatingMax = 5;
			public const int RatingMin = 1;

			public const int CommentMaxLength = 100;
			public const int CommentMinLength =3;
		}

		public static class CartItem 
		{
			public const int TextMaxLength = 300;
			public const int TextMinLength = 5;

            public const int PhoneNumberMaxLength = 50;
            public const int PhoneNumberMinLength = 5;
        }


	}
}
