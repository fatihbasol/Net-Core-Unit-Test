using System;

namespace XUnitTestProject.APP
{
    public class CalculatorService : ICalculatorService
    {
        public int Multiple(int a, int b)
        {
            // this condition only for simulate the test 
            if (a == 0)
            {
                throw new Exception("first value cannot be zero");
            }
            return a * b;
        }

        public int Sum(int a, int b)
        {
            // this condition only for simulate the test 
            if (a == 0 || b == 0)
            {
                return 0;
            }
            return a + b;
        }
    }
}
