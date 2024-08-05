using OOP_Assigment1;

namespace AssigmentTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(3, 2, 5)]
        [InlineData(-3, 2, -1)]
        [InlineData(3, -2, 1)]
        [InlineData(-3, -2, -5)]
        public void Sum_ShouldReturnCorrectResult(decimal a, decimal b, decimal expected)
        {
            var result = Calculator.Sum(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(-6, 3, -2)]
        [InlineData(6, -3, -2)]
        [InlineData(-6, -3, 2)]
        public void Divide_ShouldReturnCorrectResult(decimal a, decimal b, decimal expected)
        {
            var result = Calculator.Divide(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 3, 18)]
        [InlineData(-6, 3, -18)]
        [InlineData(6, -3, -18)]
        [InlineData(-6, -3, 18)]
        public void Multiply_ShouldReturnCorrectResult(decimal a, decimal b, decimal expected)
        {
            var result = Calculator.Multiply(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6, 3, 3)]
        [InlineData(-6, 3, -9)]
        [InlineData(6, -3, 9)]
        [InlineData(-6, -3, -3)]
        public void Subtract_ShouldReturnCorrectResult(decimal a, decimal b, decimal expected)
        {
            var result = Calculator.Subtract(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(220, 99.79)] // Example: 1 pound = 0.453592 kg, so 220 pounds = 99.79 kg
        public void ConvertPoundsToKg_ShouldReturnCorrectResult(decimal pounds, decimal expectedKg)
        {
            var result = Calculator.ConvertPoundsToKg(pounds);
            Assert.Equal(expectedKg, result);
        }

        [Theory]
        [InlineData(32, 0)] // Example: 32�F = 0�C
        [InlineData(212, 100)] // Example: 212�F = 100�C
        public void ConvertFahreheitToCelcius_ShouldReturnCorrectResult(decimal fahrenheit, decimal expectedCelsius)
        {
            var result = Calculator.ConvertFahreheitToCelcius(fahrenheit);
            Assert.Equal(expectedCelsius, result);
        }

    }

}