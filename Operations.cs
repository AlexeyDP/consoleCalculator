using System;

namespace ConsoleApp1
{
    public class Operations
    {
        public void ApplyMultiplication(double a, double b)
        {
            var result = a * b;
            Console.WriteLine(result);
        }

        public void ApplyDevision(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            var result = a / b;
            Console.WriteLine(result);
        }

        public void ApplyAddition(double a, double b)
        {
            var result = a + b;
            Console.WriteLine(result);
        }

        public void ApplySubtraction(double a, double b)
        {
            var result = a - b;
            Console.WriteLine(result);
        }
    }
}