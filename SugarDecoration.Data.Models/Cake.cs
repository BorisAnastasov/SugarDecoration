using SugarDecoration.Data.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarDecoration.Data.Models
{
    public class Cake : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int Layers { get; set; }
        public int Portion { get; set; }
        public string ImageUrl { get; set; }
        public string Ingredients { get; set; }
    }
}
