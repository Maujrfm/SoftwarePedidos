using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwarePedidos.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double ProductPrice { get; set; }
        public string ProductName { get; set; }
        public double ProductProfit { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, Product productPrice, Product productName,Product productProfit)
        {
            Quantity = quantity;
            ProductPrice = productPrice.ProductValue;
            ProductName = productName.ProductName;
            ProductProfit = productProfit.ProductProfit();
        }

        public double SubTotal()
        {
            return Quantity * ProductPrice;
        }
        public double TotalProfit()
        {
            return Quantity * ProductProfit;
        }





    }
}
