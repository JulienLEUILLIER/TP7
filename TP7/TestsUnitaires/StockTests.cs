using System;
using System.Collections.Generic;
using System.Text;
using TestsUnitaires.GenerationDeDonnees;
using Xunit;
using TP7;

namespace TestsUnitaires
{
    public class StockTests
    {
        private Stock sut;
        private Product chips = Products.Chips();
        private Client john = Clients.John();

        public StockTests()
        {
            sut = new Stock(100m);
            sut.AddProduct(chips, 10);
        }
        [Fact]
        public void GetTheRightProduct()
        {
            Assert.Equal(chips, sut.GetProductByName(chips._productName));
        }
        [Fact]
        public void TestSubstractingProduct()
        {
            sut.SubstractProduct(chips, 5, john);

            Assert.Equal(5, sut._StockProduct[chips]);
        }
    }
}
