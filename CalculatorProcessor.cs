using System;

namespace ConsoleApp1
{
    public class CalculatorProcessor
    {
        public void Process(double a, double b, Action<double, double> operationHandler)
        {
            Console.WriteLine("Performing calculation");
            operationHandler(a, b);
        }
    }
}