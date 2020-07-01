using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductCartCheckout.Model;

namespace ProductCartCheckout
{
	class Program
	{
		public static void Main(string[] args)
		{
			
            List<Product> products = new List<Product>();

            Console.WriteLine("Total number of orders");
            int a = Convert.ToInt32(Console.ReadLine());
            ProductCart pc = new ProductCart();
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                Console.WriteLine("Enter number of orders for " + type);
                int typeOrderCnt = Convert.ToInt32(Console.ReadLine());
                Product p = new Product();
                p.SKU_IDCount = typeOrderCnt;
                p.SKU_Id = type;
                p.lstorderCnt.price = pc.GetPriceByType(p);
                products.Add(p);
            }
            decimal totalPrice = pc.GetTotalPrice(products);
            Console.WriteLine("Total Price: "+ totalPrice);
            Console.ReadLine();
        }
	}
}
