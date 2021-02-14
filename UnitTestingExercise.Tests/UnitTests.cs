using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(5, 5, 5, 15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(6,5,1)]
        [InlineData(7,4,3)]
        [InlineData(5,5,0)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();

            //Act
            var actual = test.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5,5,25)]
        [InlineData(15,5,50)]
        [InlineData(6,5,30)]
        [InlineData(9,8,72)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,1)]
        [InlineData(72,9,8)]
        [InlineData(66,6,11)]
        [InlineData(99,3,33)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();

            //Act
            var actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsANumberZeroThruNine()
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();
            int[]Ofnumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Check for numbers
            foreach (int number in Ofnumbers)
            {
                //Act
                bool actual = test.IsANumberZeroThruNine(number);

                //Assert
                Assert.True(actual);
            }
        }

        [Fact]
        public void FamousLyricIJustCalledToSay()
        {
            //Arrange
            UnitTestMethods test = new UnitTestMethods();

            //Act
            string actual = test.FamousLyricIJustCalledToSay();

            //Assert
            Assert.Equal("I Love You!", actual);
        }
    }
}
