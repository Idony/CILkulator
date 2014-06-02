using System;
using Calc.SingleCalculators;
using NUnit.Framework;

namespace Calc.Tests.SingleCalculators
{
    [TestFixture]
    public class ArcctgTest
    {
        [Test]
        public void ArcctgTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("arcctg");
            double result = calc.Calculation(1);
            Assert.AreEqual(result, Math.PI / 2 - Math.Atan(1));
        }

        [Test]
        public void ArcctgTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("arcctg");
            double result = calc.Calculation(2);
            Assert.AreEqual(result, Math.PI / 2 - Math.Atan(2));
        }
    }
}
