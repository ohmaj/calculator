using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class GetOperators
    {
        public List<Operators> listOperators = new List<Operators>();
        public GetOperators()
        {
            
            listOperators.Add(new Subtract());
            listOperators.Add(new Multiply());
            listOperators.Add(new Add());
            listOperators.Add(new Divide());
            listOperators.Add(new Exponent());
        }
    }
    
}
