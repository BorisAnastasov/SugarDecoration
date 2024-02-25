namespace SugarDecoration.Data.Models.Interfaces
{
    public interface IProduct
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Ingredients { get; set; }
    }
}
