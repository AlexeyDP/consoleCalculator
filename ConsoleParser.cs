using System;
using System.Linq;

namespace ConsoleApp1
{
    public class ConsoleParser
    {
        public double AskNumber()
        {
            double result;
            Console.WriteLine("Fill in valid number");
            var input1 = Console.ReadLine();

            while (!double.TryParse(input1, out result))
            {
                Console.WriteLine("It is not a valid number");
                input1 = Console.ReadLine();
            }

            return result;
        }

        public Action<double, double> AskMathOperator()
        {
            var operations = new Operations();
            Action<double, double> operationHandler = null;

            Console.WriteLine("Fill in operations you want to do: *, +, -, /");
            var input = Console.ReadLine();
            string[] allowedOperations = { "*", "/", "+", "-" };
            while (!allowedOperations.Contains(input))
            {
                Console.WriteLine("Invalid operations");
                input = Console.ReadLine();
            }

            switch (input)
            {
                case "*":
                    operationHandler += operations.ApplyMultiplication;
                    break;
                case "/":
                    operationHandler += operations.ApplyDevision;
                    break;
                case "+":
                    operationHandler += operations.ApplyAddition;
                    break;
                case "-":
                    operationHandler += operations.ApplySubtraction;
                    break;
            }

            return operationHandler;
        }

    }
}