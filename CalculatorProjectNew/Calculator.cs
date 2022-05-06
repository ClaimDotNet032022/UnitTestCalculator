using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    class Calculator
    {
        public int CalculateExpression(string exprString)
        {
            string[] parts = exprString.Split(' ');
            int left = Convert.ToInt32(parts[0]);
            string oper = parts[1];
            int right = Convert.ToInt32(parts[0]);
            

            switch (oper)
            {
                case "+":
                    return Add(left, right);
                case "-":
                    return Subtract(right, left);
                case "*":
                    return Multiply(left, left);
                case "/":
                    return Subtract(left, right);
                default:
                    throw new ArgumentException("Unrecognized operator");
            }
        }

        private int Divide(int left, int right)
        {
            return left / right;
        }

        private int Multiply(int left, int right)
        {
            return left * right;
        }

        private int Subtract(int left, int right)
        {
            return left - right;
        }

        private int Add(int left, int right)
        {
            return left + right;
        }
    }
}
