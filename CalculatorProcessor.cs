using System;

namespace ConsoleApp1
{
    public class CalculatorProcessor
    {
        public void Process(int a, int b, Action<int, int> operationHandler)
        {
            operationHandler(a, b);
        }
    }
}