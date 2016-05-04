using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class StringToList
    {
        public StringToList()
        {

        }
        public List<string> convert(string equation)
        {
            StringBuilder equationItem = new StringBuilder();
            List<string> listEquation = new List<string>();
            int index = 0;
            foreach (char item in equation)
            {
                if (char.IsNumber(item) == true || item == '.')
                {
                    equationItem.Append(item);
                }
                else
                {
                    listEquation.Insert(index, equationItem.ToString());
                    index = index + 1;
                    equationItem.Clear();
                    listEquation.Insert(index, item.ToString());
                    index = index + 1;
                }
            }
            listEquation.Insert(index, equationItem.ToString());
            index = index + 1;
            equationItem.Clear();
            return listEquation;
        }
    }
}
