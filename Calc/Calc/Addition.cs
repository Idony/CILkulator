using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Addition
    {
        public string Add(string firstArgument, string secondArgument)
        {
            double result = Convert.ToDouble(firstArgument) + Convert.ToDouble(secondArgument);
            return  result.ToString();
        }
    }
}
