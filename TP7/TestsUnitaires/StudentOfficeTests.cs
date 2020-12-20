using System;
using TestsUnitaires.GenerationDeDonnees;
using TP7;
using Xunit;

namespace TestsUnitaires
{
    public class StudentOfficeTests
    {
        private StudentOffice sut;
        private Client john = Clients.John();
        private Client jane = Clients.Jane();

        public StudentOfficeTests()
        {
            
        }
        [Fact]
        public void TestFormatName()
        {
            Assert.Equal("DOE John", Clients.John().GetName());
        }
        [Fact]
        public void AddingSingleStudentTest()
        {
            StudentOffice.DestructStudentOffice();

            sut.AddClient(john, 5m);

            Assert.Single(sut._ClientList);
        }
        public void AddingOtherClientTest()
        {
            StudentOffice.DestructStudentOffice();

            sut.AddClient(jane, 5m);

            Assert.Single(sut._ClientList);
        }
    }
}
