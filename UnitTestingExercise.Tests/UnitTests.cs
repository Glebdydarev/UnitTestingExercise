using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2,3,4,9)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var challenge = new UnitTestMethods();

            //Act
            var actual = challenge.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(9,1,8)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var challenge = new UnitTestMethods();
            //Act
            var actual = challenge.Sub(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2,2,4)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var challenge = new UnitTestMethods();
            //Act
            var actual = challenge.Mul(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(100,2,50)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var challenge = new UnitTestMethods();

            //Act

            var actual = challenge.Div(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Hello()
        {
            //Arrange
            var challenge = new UnitTestMethods();


            //Act
            var actual = challenge.Hello();
            //Assert
            Assert.Equal("Hello", actual);

        }

        [Fact]
        public void HelloWorld()
        {
            //Arrange
            var challenge = new UnitTestMethods();

            //Act
            var actual = challenge.HelloWorld();
            //Assert
            Assert.Equal("Hello World", actual);

            
        }
    }
}
