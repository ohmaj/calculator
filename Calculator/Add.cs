using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Add:Operators
    {
        string symbol = "+";
        public string doMath(string number1, string number2)
        {
            double x = double.Parse(number1);
            double y = double.Parse(number2);
            double result = x + y;
            string stringResult = result.ToString();
            return stringResult;
        }
}
