using System;
using Xunit;
using TaschenrechnerApp;

namespace TaschenrechnerTest
{
    public class UnitTest2
    {
        [Theory]
        [InlineData(5,28,33)]
        [InlineData(4,20,24)]
        [InlineData(12,13,25)]
        [InlineData(10,150,160)]
        
        public void AddingPositiveNumber(int a,int b,int assumedResult)
        {
            //Arrange
            //Act
            var tr= new Taschenrechner();
            int ergebnis = tr.Addieren(a, b);
            //Assert
            Assert.Equal(assumedResult,ergebnis);
        }
        [Theory]
        [InlineData(-5, 28, 23)]
        [InlineData(-4, 20, 16)]
        [InlineData(12, -13, -1)]
        [InlineData(-10, -150, -160)]
        [InlineData(2, -1, 1)]
        public void AddingNegativeNumber(int a, int b, int assumedResult)
        {
            //Arrange
            //Act
            var tr = new Taschenrechner();
            int ergebnis = tr.Addieren(a, b);
            //Assert
            Assert.Equal(assumedResult, ergebnis);
        }
        [Theory]
        [InlineData(0,0, 0)]
        [InlineData(-4, 0, -4)]
        [InlineData(12, 0, 12)]
        [InlineData(0, -150, -150)]
        [InlineData(0, -1, -1)]
        public void AddingWithZeroNumber(int a, int b, int assumedResult)
        {
            //Arrange
            //Act
            var tr = new Taschenrechner();
            int ergebnis = tr.Addieren(a, b);
            //Assert
            Assert.Equal(assumedResult, ergebnis);
        }
    }
}
