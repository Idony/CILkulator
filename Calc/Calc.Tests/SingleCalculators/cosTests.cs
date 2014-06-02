using System;
using Calc.SingleCalculators;
using NUnit.Framework;

namespace Calc.Tests.SingleCalculators
{
    [TestFixture]
    public class CosTests
    {
        [Test]
        public void CosTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("cos");
            double result = calc.Calculation(0);
            Assert.AreEqual(result,(1));
        }

        [Test]
        public void CosTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("cos");
            double result = calc.Calculation(Math.PI);
            Assert.AreEqual(result,(-1));
        }
    }
}
