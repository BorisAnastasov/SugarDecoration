using SugarDecoration.Data.Entities.Interfaces;

namespace SugarDecoration.Data.Models
{
    public class CakeCategory:ICategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
