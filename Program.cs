using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operationInput;

            Console.WriteLine("Type number & press Enter");
            var input1 = Console.ReadLine();
            while (!int.TryParse(input1, out num1))
            {
                Console.WriteLine("It is not a valid number");
                input1 = Console.ReadLine();
            }

            Console.WriteLine("Choose operation & press Enter");
            operationInput = Console.ReadLine();

            Console.WriteLine("Type number & press Enter");
            var input2 = Console.ReadLine();
            while (!int.TryParse(input2, out num2))
            {
                Console.WriteLine("It is not a valid number");
                input2 = Console.ReadLine();
            }
        }
    }
}
