namespace XUnitTestProject.APP
{
    public class CalculatorService : ICalculatorService
    {
        public int Sum(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            return a + b;
        }
    }
}
