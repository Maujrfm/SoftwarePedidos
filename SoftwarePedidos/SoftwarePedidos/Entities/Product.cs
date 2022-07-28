using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePedidos.Entities
{
    class Product
    {
        public string ProductName { get; set; }
        public double ProductValue { get; set; }
        public double ProductCost { get; set; }

        public Product()
        {

        }

        public Product(string productName, double productValue)
        {
            ProductName = productName;
            ProductValue = productValue;
        }

        public Product(string productName, double productValue, double productCost) : this(productName, productValue)
        {
            ProductCost = productCost;
        }

        public double ProductProfit()
        {
            return ProductValue - ProductCost;
        }
    }
}
