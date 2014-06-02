using System;
using Calc.SingleCalculators;
using NUnit.Framework;

namespace Calc.Tests.SingleCalculators
{
    [TestFixture]
    public class SinusTest
    {
        [Test]
        public void SinusTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("sin");
            double result = calc.Calculation(3.14);
            Assert.AreEqual(result, Math.Sin(3.14));
        }

        [Test]
        public void SinusTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("sin");
            double result = calc.Calculation(1);
            Assert.AreEqual(result, Math.Sin(1));
        }
    }
}
