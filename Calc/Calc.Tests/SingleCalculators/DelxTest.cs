using System;
using Calc.SingleCalculators;
using NUnit.Framework;

namespace Calc.Tests.SingleCalculators
{
    [TestFixture]
    public class DelxTests
    {
        [Test]
        public void delxTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("1/x");
            double result = calc.Calculation(2);
            Assert.AreEqual(result, 0.5);
        }

        [Test]
        public void DelxTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("1/x");
            double result = calc.Calculation(5);
            Assert.AreEqual(0.2, result);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void DelxTest3()
        {
            ISingleOperation calc = SingleOperationFactory.Create("1/x");
            double result = calc.Calculation(0);
        }
    }
}
