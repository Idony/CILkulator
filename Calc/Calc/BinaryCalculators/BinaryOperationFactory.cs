using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Calc.BinaryCalculators
{
    public static class BinaryOperationFactory
    {
        public static IBinaryOperation Create(string calculatorName)
        {
            switch (calculatorName)
            {
                 case "+":
                    return new Adder();
                 case "-":
                    return new Substracter();
                 case "/":
                    return new Divider();
                 case "*":
                    return new Multiplier();
                 case "x^y":
                    return new Power();
                 case "x^(1/y)":
                    return new PowerSqrt();
                 case "Log":
                    return new Log();
                 case "%":
                    return new Modilo();

                default:
                    throw new ArgumentException("ПИШИ ПРАВИЛЬНО УВАСЯ!!", "calculatorName");

            }
        }
    }
}
