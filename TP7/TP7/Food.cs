using System;
using System.Collections.Generic;
using System.Text;

namespace TP7
{
    public class Food : Product
    {
        public Food(string productName, decimal buyPrice, decimal memberPrice, decimal notMemberPrice) : base(productName, buyPrice, memberPrice, notMemberPrice)
        {
        }
    }
}
