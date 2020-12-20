using System;
using TestsUnitaires.GenerationDeDonnees;
using Xunit;

namespace TestsUnitaires
{
    public class BDETests
    {
        [Fact]
        public void TestFormatName()
        {
            Assert.Equal("DOE John", Clients.John().GetName());
        }
        [Fact]
        public void AddingStudentTest()
        {
            
        }
    }
}
