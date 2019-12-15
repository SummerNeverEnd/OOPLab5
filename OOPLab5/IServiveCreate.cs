using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    interface IServiceCreate
    {
        public Shop CreateShop(int shopId, string shopName);
        public Product CreateProduct(string productName, int productCount, decimal productPrice);
    }
}