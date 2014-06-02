using System;
using Calc.SingleCalculators;
using NUnit.Framework;

namespace Calc.Tests.SingleCalculators
{
    [TestFixture]
    public class FactorialTests
    {
        [Test]
        public void FactorialTest1()
        {
            ISingleOperation calc= SingleOperationFactory.Create("n!");
            double result = calc.Calculation(5);
            Assert.AreEqual(result,120);
        }

        [Test]
        public void FactorialTest2()
        {
            ISingleOperation calc= SingleOperationFactory.Create("n!");
            double result = calc.Calculation(7);
            Assert.AreEqual(5040,result);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void FactorialTest3()
        {
            ISingleOperation calc = SingleOperationFactory.Create("n!");
            double result = calc.Calculation(-2);
        }
    }
}

