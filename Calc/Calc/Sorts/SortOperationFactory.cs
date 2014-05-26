﻿using System;

namespace Calc.Sorts
{
    public static class SortOperationFactory
    {
        public static ISort Create(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Qsort":
                    return new QSort();
                case "InsertionSort":
                    return new InsertionSort();
                case "Pozyrek":
                    return new Pozyrek();
                case "SelectionSort":
                    return new SelectionSort();
                default:
                    throw new ArgumentException("ПИШИ ПРАВИЛЬНО УВАСЯ!!", "calculatorName");

            }
        }
    }
}
