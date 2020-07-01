using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductCartCheckout.Model;

namespace ProductCartCheckout
{
	public interface IProductCart
	{
		//void GetPriceByType(Product product);
		decimal GetTotalPrice(List<Product> products);
	}
}
