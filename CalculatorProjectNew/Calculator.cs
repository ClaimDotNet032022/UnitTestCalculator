using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class Calculator
    {
        private readonly IParser _parser;

        public Calculator(IParser parser)
        {
            _parser = parser;
        }

        public int CalculateExpression(string exprString)
        {
            BinaryOperation binaryOperation = _parser.Parse(exprString);
            return CalculateExpression(binaryOperation);
        }

        public int CalculateExpression(BinaryOperation binary)
        {
            switch (binary.Operator)
            {
                case "+":
                    return Add(binary.Left, binary.Right);
                case "-":
                    return Subtract(binary.Right, binary.Left);
                case "*":
                    return Multiply(binary.Left, binary.Left);
                case "/":
                    return Divide(binary.Left, binary.Right);
                default:
                    throw new ArgumentException("Unrecognized operator");
            }
        }

        public int Divide(int left, int right)
        {
            return left / right;
        }

        public int Multiply(int left, int right)
        {
            return left * right;
        }

        public int Subtract(int left, int right)
        {
            return left - right;
        }

        public int Add(int left, int right)
        {
            return left + right;
        }
    }
}
