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
        public void Sum_SimpleValues_ReturnTotalValue(int a, int b, int expectedValue)
        {

            _repository.Setup(x => x.Sum(a, b)).Returns(expectedValue);

            var actualTotal = _calculator.Sum(a, b);

            Assert.Equal(expectedValue, actualTotal);
        }
    }
}
