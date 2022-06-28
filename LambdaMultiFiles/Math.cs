using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaMultiFiles
{
    internal class Math
    {
        public Math() { }

        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public decimal Multiplication(int num1, int num2)
        {
            return (decimal)num1 * num2;
        }

        public decimal Division(int num1, int num2)
        {
            return Decimal.Round(((decimal)num1 / (decimal)num2), 3);
        }
    }
}
