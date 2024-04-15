using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarDecoration.Core.Models.Order
{
	public class OrderDetailsModel
	{
        public int Id { get; set; }
		public string OrderDate { get; set; }
		public int ItemCount { get; set; }
    }
}
