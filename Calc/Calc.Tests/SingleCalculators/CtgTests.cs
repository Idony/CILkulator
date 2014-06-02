using System;
using Calc.SingleCalculators;
using NUnit.Framework;

namespace Calc.Tests.SingleCalculators
{
    [TestFixture]
    public class CtgTests
    {
        [Test]
        public void CtgTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("ctg");
            double result = calc.Calculation(2);
            Assert.AreEqual(result, 1/Math.Tan(2));
        }

        [Test]
        public void CtgTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("ctg");
            double result = calc.Calculation(3);
            Assert.AreEqual(1/Math.Tan(3), result);
        }
    }
}
