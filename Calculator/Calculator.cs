using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public Calculator()
        {
            
        }
        public List<string> listEquation()
        {
            
            string getEquation = Console.ReadLine();
            StringToList stringToList = new StringToList();
            List<string> listEquation = stringToList.convert(getEquation);
            return listEquation;
        }
        public string math()
        {
            GetOperators operators = new GetOperators();
            List<string> equation = listEquation();
            foreach(Operators operation in operators.listOperators)
            {
                foreach (string item in equation)
                {
                    if (operation.symbol == item)
                    {

                        int index = equation.IndexOf(item);
                        string number1 = equation.ElementAt(index - 1);
                        string number2 = equation.ElementAt(index + 1);

                        string result = operation.doMath();
                    }
                }
            }
         }
    }
}
