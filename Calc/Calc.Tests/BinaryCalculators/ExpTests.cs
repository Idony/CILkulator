using System;
using Calc.BinaryCalculators;
using Calc.SingleCalculators;
using NUnit.Framework;

namespace Calc.Tests.BinaryCalculators
{
    [TestFixture]
    public class ExpTests
    {
        [Test]
        public void ExpTest1()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("exp");
            double result = calc.Calculation(2, 2);
            Assert.AreEqual(result, 200);
        }

        [Test]
        public void ExpTest2()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("exp");
            double result = calc.Calculation(6, 8);
            Assert.AreEqual(result, 600000000);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpTest3()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("exp");
            double result = calc.Calculation(3,-4);
        }
    }
}
