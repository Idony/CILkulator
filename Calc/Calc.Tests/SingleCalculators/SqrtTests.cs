using System;
using Calc.SingleCalculators;
using NUnit.Framework;

namespace Calc.Tests.SingleCalculators
{
    [TestFixture]
    public class SqrtTests
    {
        [Test]
        public void SqrtTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("sqrt");
            double result = calc.Calculation(4);
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void SqrtTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("sqrt");
            double result = calc.Calculation(9);
            Assert.AreEqual(result, 3);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void SqrtTest3()
        {
            ISingleOperation calc = SingleOperationFactory.Create("sqrt");
            double result = calc.Calculation(-2);
        }
    }
}
