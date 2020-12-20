using System;
using System.Collections.Generic;
using System.Text;
using TestsUnitaires.GenerationDeDonnees;
using TP7;
using Xunit;

namespace TestsUnitaires
{
    public class SellingTests
    {
        private StudentOffice sut;
        private readonly Client john = Clients.John();
        private readonly Product chips = Products.Chips();
        
        public SellingTests()
        {
            sut = new StudentOffice();
            sut.AddClient(john, 20m);
            sut._currentStock.AddProduct(chips, 50);
            sut.SellProduct(john, chips, 5);
        }

        [Fact]
        public void GetRightPrice()
        {
            decimal price = john.GetAppropriatePrice(chips);

            Assert.Equal(1.0m, price);
        }
        [Fact]
        public void StockChangeTest()
        {
            Assert.Equal(45, sut._currentStock._StockProduct[chips]);
        }
        [Fact]
        public void ClientBalanceChangeTest()
        {
            Assert.Equal(15, sut._ClientList[john]);
        }

        [Fact]
        public void StudentOfficeBalanceChangeTest()
        {
            Assert.Equal(80, sut._currentStock.CurrentBalance);
        }
    }
}
