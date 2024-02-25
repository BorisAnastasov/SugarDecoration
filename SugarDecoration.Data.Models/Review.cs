using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarDecoration.Data.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int CostumerId { get; set; }
        public int ProductId { get; set; }
        public string Commment { get; set; }
        public double Rating { get; set; }
    }
}
