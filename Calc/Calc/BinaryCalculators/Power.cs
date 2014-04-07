using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.BinaryCalculators
{
    public class Power : IBinaryOperation
    {
        public double Calculation(double firstArgument, double secondArgument)
        {
            double result = Math.Pow( firstArgument, secondArgument);
            return result;
        }
    }
}
