using System;
using System.Collections.Generic;
using System.Text;

namespace TP7
{
    public abstract class Product
    {
        public readonly string _productName;
        public readonly decimal _buyPrice;
        public readonly decimal _memberPrice;
        public readonly decimal _notMemberPrice;

        protected Product(string productName, decimal buyPrice, decimal memberPrice, decimal notMemberPrice)
        {
            _productName = productName;
            _buyPrice = buyPrice;
            _memberPrice = memberPrice;
            _notMemberPrice = notMemberPrice;
        }
    }
}
