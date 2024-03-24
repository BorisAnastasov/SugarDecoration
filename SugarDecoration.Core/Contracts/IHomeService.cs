using SugarDecoration.Core.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarDecoration.Core.Contracts
{
	public interface IHomeService
	{
		Task<IEnumerable<ProductIndexServiceModel>> TakeFiveProducts();
	}
}
