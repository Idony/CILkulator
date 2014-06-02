﻿using System;

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
                 case "log":
                    return new Log();
                 case "mod":
                    return new Modilo();
                 case "exp":
                    return new Exp();
                 case "rank":
                    return new Xi();
                 case "srhombus":
                    return new Srhombus();
                 default:
                    throw new ArgumentException("ПИШИ ПРАВИЛЬНО УВАСЯ!!", "calculatorName");

            }
        }
    }
}
