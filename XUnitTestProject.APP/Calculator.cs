namespace XUnitTestProject.APP
{
    public class Calculator
    {
        private ICalculatorService _calculatorService { get; set; }

        public Calculator(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        public int Sum(int a, int b)
        {
            return _calculatorService.Sum(a, b);
        }
    }
}
