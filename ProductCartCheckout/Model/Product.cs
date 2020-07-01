using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCartCheckout.Model
{
   
    public class Product
    {
        public string SKU_Id { get; set; }
        public int SKU_IDCount { get; set; }
        public decimal Price { get; set; }

        public ProductDetails lstorderCnt { get; set; }

        public decimal TotalValue { get; set; }
        public Product(string id)
        {
            this.SKU_Id = id;
            switch (id)
            {
                case "A":
                    this.Price = 50m;

                    break;
                case "B":
                    this.Price = 30m;

                    break;
                case "C":
                    this.Price = 20m;

                    break;
                case "D":
                    this.Price = 15m;
                    break;
            }
        }
    }
}

