﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarDecoration.Core.Models.Biscuit
{
	public class BiscuitServiceModel
	{
		public string Name { get; set; }
		public double Price { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
	}
}