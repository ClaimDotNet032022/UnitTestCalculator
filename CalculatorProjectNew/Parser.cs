using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class Parser : IParser
    {
        public BinaryOperation Parse(string exprString)
        {
            string[] parts = exprString.Split(' ');
            int left = Convert.ToInt32(parts[0]);
            string oper = parts[1];
            int right = Convert.ToInt32(parts[2]);

            BinaryOperation result = new BinaryOperation
            {
                Left = left,
                Operator = oper,
                Right = right
            };

            return result;
        }
    }
}
