using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] 
        [InlineData(9,8,7,24)]//Add test data <-------
        [InlineData(2,5,7,14)]
        [InlineData(4,3,1,8)]
        [InlineData(67,2345,500,2912)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:
            //Arrange
            // create a Calculator object
            var Addition = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = Addition.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(7, 7, 0)]
        [InlineData(-9, 6, -15)]
        [InlineData(9, -13, 22)]
        [InlineData(78,9,69)]
        [InlineData(987,789,198)]
        [InlineData(67,23,44)]
        [InlineData(56,34,22)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var Subtraction = new Calculator();
            //Act
            var actual = Subtraction.Substract(minuend, subtrahend);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(7, 3, 21)]
        [InlineData(8, 0, 0)]
        [InlineData(98,2,196)]
        [InlineData(5,0,0)]
        [InlineData(0,6,0)]
        [InlineData(20,4,80)]
        [InlineData(65,5,325)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var Multiplication = new Calculator();
            //Act
            var actual = Multiplication.Multiply(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(70, 5, 14 )]
        [InlineData(8, 4, 2 )]
        [InlineData(8,4,2)]
        [InlineData(36,6,6)]
        [InlineData(24,8,3)]
        [InlineData(44,22,2)]
        [InlineData(270,90,3)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var Division = new Calculator();
            //Act
            var actual = Division.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

    }
}
