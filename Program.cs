using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new ConsoleParser();
            var processor = new CalculatorProcessor();

            double num1 = parser.AskNumber();
            Action<double, double> op = parser.AskMathOperator();
            double num2 = parser.AskNumber();

            processor.Process(num1, num2, op);
            Console.ReadKey();
        }
    }
}
