using System;

namespace Calc.SingleCalculators
{
    public static class SingleOperationFactory
    {
        public static ISingleOperation Create(string calculatorName)
        {
            switch (calculatorName)
            {
                case "x^2":
                   return new Square();
                case "sqrt":
                   return new Sqrt();
                case "arccos":
                    return new Arccos();
                case "tan":
                    return new Tan();
                case "sin":
                    return new Sin();
                case "ln":
                    return new Ln();
                case "x^3":
                    return new Cubed();
                case "n!":
                    return new Factorial();
                case "sqrt^3":
                    return new Sqrt3();
                case "lg":
                    return new Lg();
                case "arctg":
                    return new Arctg();
                case "arcsin":
                    return new Arcsin();
                case "ctg":
                    return new Ctg();
                case "arcctg":
                    return new Arcctg();
                case "1/x":
                    return new Delx();
                case "cos":
                    return new Cos();
                case "+/-":
                    return new Swap();
                default:
                    throw new ArgumentException("ПИШИ ПРАВИЛЬНО УВАСЯ!!", "calculatorName");

            }
        }
    }
}
