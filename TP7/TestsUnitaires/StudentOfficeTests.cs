using System;
using TestsUnitaires.GenerationDeDonnees;
using TP7;
using Xunit;

namespace TestsUnitaires
{
    public class StudentOfficeTests
    {
        private StudentOffice sut;
        private readonly Client john = Clients.John();
        private readonly Client jane = Clients.Jane();

        public StudentOfficeTests()
        {
            sut = new StudentOffice();
        }
        [Fact]
        public void TestFormatName()
        {
            Assert.Equal("DOE John", john.GetName());
        }

        [Fact]
        public void GetRightClient()
        {
            sut._ClientList.Add(john, 5);

            Assert.True(sut.GetClientByName(john.GetName()));
        }
        [Fact]
        public void AddingSingleStudentTest()
        {
            sut = new StudentOffice();
            sut.AddClient(john, 5m);

            Assert.Single(sut._ClientList);
        }
        [Fact]
        public void AddingOtherClientTest()
        {
            sut.AddClient(jane, 5m);

            Assert.Single(sut._ClientList);
        }
    }
}
