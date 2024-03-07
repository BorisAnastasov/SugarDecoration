namespace SugarDecoration.Infrastructure.Data.Interfaces
{
	public interface IProduct
	{
        string Name { get; set; }
        double Price { get; set; }
        string ImageUrl { get; set; }
        int CategoryId { get; set; }
    }
}
