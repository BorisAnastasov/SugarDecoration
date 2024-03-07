namespace SugarDecoration.Infrastructure.Data.Models
{
	public class Cart
	{
        public int Id { get; set; }
        public string CostumerId { get; set; } = null!;
        public double TotalPrice { get; set; }
    }
}
