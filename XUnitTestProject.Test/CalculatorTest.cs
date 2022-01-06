using Moq;
using Xunit;
using XUnitTestProject.APP;

namespace XUnitTestProject.Test
{
    public class CalculatorTest
    {
        private Mock<ICalculatorService> _repository;
        private Calculator _calculator;
        public CalculatorTest()
        {
            _repository = new Mock<ICalculatorService>();
            _calculator = new Calculator(_repository.Object);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(5, 7, 12)]
        public void Sum_SimpleValues_ReturnsTotalValue(int a, int b, int expectedValue)
        {
            _repository.Setup(x => x.Sum(a, b)).Returns(expectedValue);
            var actualTotal = _calculator.Sum(a, b);
            Assert.Equal(expectedValue, actualTotal);
        }

        [Theory]
        [InlineData(0, 15, 0)]
        [InlineData(15, 0, 0)]
        public void Sum_ZeroValues_ReturnsZero_WhenAnyValueZero(int a, int b, int expectedValue)
        {
            _repository.Setup(x => x.Sum(a, b)).Returns(expectedValue);
            var result = _calculator.Sum(a, b);
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(4, 4, 16)]
        [InlineData(4, 0, 0)]
        public void Multiple_SimpleValues_ReturnsMultiple(int a, int b, int expected)
        {
            _repository.Setup(x => x.Multiple(a, b)).Returns(expected);
            var actual = _calculator.Multiple(a, b);
            Assert.Equal(expected, actual);
        }
    }
}
