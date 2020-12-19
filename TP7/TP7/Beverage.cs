using System;
using System.Collections.Generic;
using System.Text;

namespace TP7
{
    public class Beverage : Product
    {
        public Beverage(string productName, decimal buyPrice, decimal memberPrice, decimal notMemberPrice) : base(productName, buyPrice, memberPrice, notMemberPrice)
        {
        }
    }
}
