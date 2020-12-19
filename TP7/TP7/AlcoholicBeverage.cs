using System;
using System.Collections.Generic;
using System.Text;

namespace TP7
{
    public class AlcoholicBeverage : Product
    {
        public readonly float _alcoholDegree;

        public AlcoholicBeverage(string productName, decimal buyPrice, decimal memberPrice, decimal notMemberPrice, float alcohoholDegree) : base(productName, buyPrice, memberPrice, notMemberPrice)
        {
            _alcoholDegree = alcohoholDegree;
        }
    }
}
