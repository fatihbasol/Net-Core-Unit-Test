namespace XUnitTestProject.APP
{
    public class Calculator
    {
        private CalculatorService _calculatorService { get; set; }

        public Calculator(CalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        public int Sum(int a, int b)
        {
            return _calculatorService.Sum(a, b);
        }
    }
}
