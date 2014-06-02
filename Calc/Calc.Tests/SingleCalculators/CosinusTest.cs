using System;
using Calc.SingleCalculators;
using NUnit.Framework;

namespace Calc.Tests.SingleCalculators
{
    [TestFixture]
    public class CosinusTest
    {
        [Test]
        public void CosinusTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("cos");
            double result = calc.Calculation(3.14);
            Assert.AreEqual(result, Math.Cos(3.14));
        }

        [Test]
        public void CosinusTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("cos");
            double result = calc.Calculation(1);
            Assert.AreEqual(result, Math.Cos(1));
        }
    }
}
