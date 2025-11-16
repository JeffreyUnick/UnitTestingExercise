using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] 
        [InlineData(0,0,0,0)]//Add test data <-------
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
        [InlineData(9, -13, 22)]//Add test data <-------
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
        [InlineData(8, 0, 0)]//Add test data <-------
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
        [InlineData(8, 4, 2 )]//Add test data <-------
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
