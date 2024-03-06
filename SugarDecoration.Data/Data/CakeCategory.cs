using SugarDecoration.Data.Entities.Interfaces;

namespace SugarDecoration.Data
{
    public class CakeCategory:ICategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
