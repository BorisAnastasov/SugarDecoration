using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarDecoration.Core.ViewModels.Contracts
{
    public interface IFormProductViewModel
    {
        public string Title { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
