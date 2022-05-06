using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            while (true)
            {
                Console.WriteLine("Enter an expression like '3 + 7': ");
                string input = Console.ReadLine();
                try
                {
                    int result = calc.CalculateExpression(input);
                    Console.WriteLine("Answer: {0}", result);
                }
                catch
                {
                    Console.WriteLine("Something went wrong.");
                }

                Console.WriteLine();
            }
        }
    }
}
