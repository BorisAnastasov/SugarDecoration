using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SugarDecoration.Infrastructure.Data.Models;

namespace SugarDecoration.Infrastructure.Data.Configuration
{
	internal class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasData(
			new Product
			{
				Id = 1,
				Title = "Съпруг и съпруга със сини и бели рози",
				Price = 100.00,
				CreatedOn = DateTime.Now,
				ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t1.6435-9/45418292_1900224123436935_5112515879866728448_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=5f2048&_nc_ohc=eFIio2QbBlEAX9Yzjue&_nc_ht=scontent-sof1-1.xx&oh=00_AfBoQ7qqdl47HZ7hWnAk-no9njwdW7bf1dMJizkc5xCsOQ&oe=6613AA58",
			},
			new Product
			{
				Id = 2,
				Title = "Златни рози",
				Price = 120.00,
				CreatedOn = DateTime.Now,
				ImageUrl = "https://scontent-sof1-1.xx.fbcdn.net/v/t31.18172-8/11950324_881502548642436_5301516909345454510_o.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=im4NrlMRDwoAX906LIT&_nc_ht=scontent-sof1-1.xx&oh=00_AfANMiRCdEFjBHMKqzdVQ8CfmwHERZjyswaGHkTpw3deDw&oe=66139F73"
			},
			new Product
			{
				Id = 3,
				Title = "Съпруг и съпруга с червени рози и бели цветя",
				Price = 150.00,
				CreatedOn = DateTime.Now,
				ImageUrl = "https://scontent-sof1-2.xx.fbcdn.net/v/t1.6435-9/118890298_3193596277433040_3828589938106568560_n.jpg?_nc_cat=110&ccb=1-7&_nc_sid=5f2048&_nc_ohc=dMYD1Y2twPAAX-5TIdq&_nc_oc=AQmB6ydQvkgot9gup32CReBa78Uc9nJ0lxvLge5csyOGMtoviBAviNqd5ot6C3mvjZ4&_nc_ht=scontent-sof1-2.xx&oh=00_AfCKvMW1pK86G0-3Uvc3A4efBy5a7ZXvntK3EIguunlpsg&oe=6613AE2C"
			},
			new Product
			{
				Id = 4,
				Title = "бели цветя",
				Price = 120.00,
				CreatedOn = DateTime.Now,
				ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t31.18172-8/11940464_881502551975769_3150965239804644226_o.jpg?_nc_cat=111&ccb=1-7&_nc_sid=5f2048&_nc_ohc=lIiz0CvrQOAAX8yrHv6&_nc_ht=scontent.fsof10-1.fna&oh=00_AfDS01MUNTFuECPkpvob8zZZXmMJKbYgvCTwQahwOQCQIg&oe=6620333B"
			},
			new Product
			{
				Id = 5,
				Title = "бели цветя",
				Price = 110.00,
				CreatedOn = DateTime.Now,
				ImageUrl = "https://scontent.fsof10-1.fna.fbcdn.net/v/t1.6435-9/81678509_2608157715976902_8711874778027261952_n.jpg?_nc_cat=100&ccb=1-7&_nc_sid=5f2048&_nc_ohc=dn9ncHjKXt8AX8V4imn&_nc_oc=Adjiqz8TQNQuH0VsI2W2J8AQwDjcgr4XPGHPeTXPJ2qkeaZqY5bGxFIsMXkoAPWg4Jo&_nc_ht=scontent.fsof10-1.fna&oh=00_AfAjqqJ0cgKuP1WozZm7dEPBE_51dVR12bcJ2UmxChzeYg&oe=66201CA0"
			}


			);
		}
	}
}
