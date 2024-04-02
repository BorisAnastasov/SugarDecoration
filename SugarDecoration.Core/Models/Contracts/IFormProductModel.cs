namespace SugarDecoration.Core.Models.Contracts
{
	public interface IFormProductModel
    {
        public string Title { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public string CreatedOn { get; set; }
    }
}
