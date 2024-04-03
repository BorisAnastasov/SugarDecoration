namespace SugarDecoration.Core.Models.Cart
{
    public class DeleteCartViewModel
    {
        public int Id { get; set; }
        public int TotalItemCount { get; set; }
        public string CreatedOn { get; set; } = string.Empty;
    }
}
