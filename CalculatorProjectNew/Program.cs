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
            Console.WriteLine("Do you prefer normal notation?");
            Console.WriteLine("Enter Y for normal, N for Reverse Polish:");
            string userPref = Console.ReadLine();

            IParser parser;
            if (userPref.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                parser = new Parser();
            }
            else
            {
                parser = new ReversePolishParser();
            }


            var calc = new Calculator(parser);
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
