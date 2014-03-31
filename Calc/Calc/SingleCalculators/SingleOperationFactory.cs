using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
                case "X^2":
                   return new Square();
                case "Sqrt":
                   return new Sqrt();
                default:
                    throw new ArgumentException("ПИШИ ПРАВИЛЬНО УВАСЯ!!", "calculatorName");

            }
        }
    }
}
