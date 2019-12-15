using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    interface IServiceChange
    {
        public void AddProduct(int shopId, Product product);
        public decimal Buy(int shopId, string productName, int productCount);
    }
}