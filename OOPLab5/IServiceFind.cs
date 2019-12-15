using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    interface IServiceFind
    {
        public Shop FindCheapestSum(params Product[] products);
        public Shop FindCheapest(string productName);

    }
}