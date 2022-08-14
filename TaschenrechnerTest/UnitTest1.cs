using System;
using Xunit;
using TaschenrechnerApp;

namespace TaschenrechnerTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = -5;
            int b = 10;
            //Act
            var taschenRechner = new Taschenrechner();
            int result = taschenRechner.Addieren(a, b);
            //Assert
            Assert.Equal(5, result);
        }
        [Fact]
        public void Test2()
        {
            //Arrange
            int a = 5;
            int b = 10;
            //Act
            var taschenRechner = new Taschenrechner();
            int result= taschenRechner.Addieren(a,b);
            //Assert
            Assert.Equal(15, result);
        }
    }
}
