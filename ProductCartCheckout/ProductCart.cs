using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductCartCheckout.Model;

namespace ProductCartCheckout
{
	class ProductCart : IProductCart
	{
        public decimal GetPriceByType(Product product)
        {
            switch (product.SKU_Id)
            {
                case "A":
                case "a":
                    product.Price = 50m;

                    break;
                case "B":
                case "b":
                    product.Price = 30m;

                    break;
                case "C":
                case "c":
                    product.Price = 20m;

                    break;
                case "D":
                case "d":
                    product.Price = 2015m;
                    break;
            }
            return product.Price;
        }


        public decimal GetTotalPrice(List<Product> products)
        {
            int counterOfA = 0;
            int counterOfB = 0;
            int counterOfC = 0;
            int counterOfD = 0;
            decimal TotalValue = 0;

            foreach (Product pr in products)
            {
                pr.lstorderCnt = new ProductDetails();

                switch (pr.SKU_Id)
                {
                    case "A":
                    case "a":
                        if (pr.SKU_IDCount / 3 > 0)
                            counterOfA = pr.SKU_IDCount / 3;
                        pr.lstorderCnt.totalPriceOfA = counterOfA * 130 + (pr.SKU_IDCount % 3 * pr.Price);
                        TotalValue += pr.lstorderCnt.totalPriceOfA;
                        break;
                    case "B":
                    case "b":
                        if (pr.SKU_IDCount / 2 > 0)
                            counterOfB = pr.SKU_IDCount / 2;
                        pr.lstorderCnt.totalPriceOfB = counterOfB * 45 + (pr.SKU_IDCount % 2 * pr.Price);
                        TotalValue += pr.lstorderCnt.totalPriceOfB;
                        break;
                    case "C":
                    case "c":
                       
                        counterOfC = pr.SKU_IDCount;
                        pr.lstorderCnt.totalPriceOfC = (counterOfC * pr.Price);
                        TotalValue += pr.lstorderCnt.totalPriceOfC;
                        break;
                    case "D":
                    case "d":
                        counterOfD = pr.SKU_IDCount;
                        pr.lstorderCnt.totalPriceOfD = (counterOfD * pr.Price);
                        TotalValue += pr.lstorderCnt.totalPriceOfD;
                        break;
                }

            }

            return TotalValue;
        }
    }
}
