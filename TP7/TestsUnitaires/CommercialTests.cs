using System;
using System.Collections.Generic;
using System.Text;
using TestsUnitaires.GenerationDeDonnees;
using TP7;
using Xunit;

namespace TestsUnitaires
{
    public class CommercialTests
    {
        private readonly Commercial commercial;

        public CommercialTests()
        {
            commercial = new Commercial();
        }

        [Fact]
        public void CanOrderBeverage()
        {            
            commercial.AddProduct("water", EnumTypeProduct.Beverage, Products.WaterPrice(), 0);
            Assert.IsType<Beverage>(commercial.Order("water"));
            Assert.IsNotType<AlcoholicBeverage>(commercial.Order("water"));
        }
    }
}
