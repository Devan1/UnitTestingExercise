using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var testAdd = new UnitTestMethods();
            //Act
            var actual = testAdd.add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,2,8)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var testSubtract = new UnitTestMethods();
            //Act
            var actual = testSubtract.subract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,2,20)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var testMultiply = new UnitTestMethods();
            //Act
            var actual = testMultiply.multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,2,5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var testDivide = new UnitTestMethods();
            //Act
            var actual = testDivide.divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Factmul()
        {
            //Arrange
            var testFactmul = new UnitTestMethods();
            //Act
            var actual = testFactmul.factmul();
            //Assert
            Assert.Equal(6, actual);
        }

        [Fact]
        public void Factdiv()
        {
            //Arrange
            var testFactdiv = new UnitTestMethods();
            //Act
            var actual = testFactdiv.factdiv();
            //Assert
            Assert.Equal(2, actual);
        }
    }
}
