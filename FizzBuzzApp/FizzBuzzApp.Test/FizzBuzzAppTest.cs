using System.Collections.Generic;
using FizzBuzzApp.Factories;
using FizzBuzzApp.Services;
using Xunit;

namespace FizzBuzzApp.FizzBuzzApp.Test
{
    public class FizzBuzzAppTest
    {
        private readonly FizzBuzzService _fizzBuzzService;

        public FizzBuzzAppTest()
        {
            // Initialize the service
            _fizzBuzzService = new FizzBuzzService();
        }

        [Fact]
        public void CheckForFizzWhenMultipleOf3()
        {
            // Arrange
            var input = new object[] { 3 };

            // Act
            var result = _fizzBuzzService.CheckFizzBuzz(input);

            // Assert
            Assert.Contains("Fizz", result);
            
        }

        [Fact]
        public void CheckForBuzzWhenMultipleOf5()
        {
            // Arrange
            var input = new object[] { 5 };

            // Act
            var result = _fizzBuzzService.CheckFizzBuzz(input);

            // Assert
            Assert.Contains("Buzz", result);
        }

        [Fact]
        public void CheckForFizzBuzzWhenMultipleOf3WhenMultipleOf3And5()
        {
            // Arrange
            var input = new object[] { 15 };

            // Act
            var result = _fizzBuzzService.CheckFizzBuzz(input);

            // Assert
            Assert.Contains("FizzBuzz", result);
        }

        [Fact]
        public void CheckForInvalidStringValue()
        {
            // Arrange
            var input = new object[] { "TEST" };

            // Act
            var result = _fizzBuzzService.CheckFizzBuzz(input);

            // Assert
            Assert.Contains("Invalid Value", result);
        }

        [Fact]
        public void CheckForEmptyString()
        {
            // Arrange
            var input = new object[] { "" };

            // Act
            var result = _fizzBuzzService.CheckFizzBuzz(input);

            // Assert
            Assert.Contains("Invalid Value", result);
        }

        [Fact]
        public void CheckForMultipleValues()
        {
            // Arrange
            var input = new object[] { 3, 5, "TEST", 15 };

            // Act
            var result = _fizzBuzzService.CheckFizzBuzz(input);

            // Assert
            Assert.Contains("Fizz", result);
            Assert.Contains("Buzz", result);
            Assert.Contains("Invalid Value", result);
            Assert.Contains("FizzBuzz", result);
            
        }
    }
  
}
