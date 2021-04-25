
using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your first number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input your second number");
            int secondNumber = int.Parse(Console.ReadLine());


            int result = firstNumber % secondNumber;

            Console.WriteLine($"Your remainder for the division is {result}");


        }


    }
}
