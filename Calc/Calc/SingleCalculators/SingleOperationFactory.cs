using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.SingleCalculators
{
    public static class SingleOperationFactory
    {
        public static ISingleOperation Create(string calculatorName)
        {
            switch (calculatorName)
            {
                case "ln":
                    return new Ln();
                case "cubes":
                    return new Cubed();
                case "sin":
                    return new Sin();
                case "arccos":
                    return new Arccos();
                case "tan":
                    return new Tan();
                default:
                    throw new ArgumentException("ПИШИ ПРАВИЛЬНО УВАСЯ!!", "calculatorName");

            }
        }
    }
}
