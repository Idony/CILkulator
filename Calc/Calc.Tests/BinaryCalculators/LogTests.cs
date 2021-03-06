﻿using System;
using Calc.BinaryCalculators;
using NUnit.Framework;

namespace Calc.Tests.BinaryCalculators
{
    [TestFixture]
    public class LogTests
    {
        [Test]
        public void LogTest1()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("log");
            double result = calc.Calculation(9,3);
            Assert.AreEqual(result,2);
        }

        [Test]
        public void LogTest2()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("log");
            double result = calc.Calculation(25, 5);
            Assert.AreEqual(result, 2);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void LogTest3()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("log");
            double result = calc.Calculation(3, -4);
        }
    }
}
