using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add two numbers \n2. Add list of numbers");
            int tanov=int.Parse(Console.ReadLine());

            if (tanov==1)
            {
                Console.Write("Enter first number: ");
                int num1=int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int num2=int.Parse(Console.ReadLine());
                Console.WriteLine($"result: {num1 + num2}");
            }
            else if(tanov==2)
            {
                int sum = 0;
                Console.WriteLine("Enter comma-separated (,) integer values: ");
                string satr=Console.ReadLine();
                string[] Arraysatr = satr.Split(",");
                foreach (string i in Arraysatr)
                {
                    int b=int.Parse(i);
                    sum += b;

                }
                Console.WriteLine($"Resualt: {sum}");
            }
            else
            {
                Console.WriteLine("Enter the number 1 or 2!");
            }

        }
    }
}


