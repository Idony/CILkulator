using Calc.BinaryCalculators;
using NUnit.Framework;

namespace Calc.Tests.BinaryCalculators
{
    [TestFixture]
    public class SubstracterTests
    {
        [Test]
        public void SubstracterTest1()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("-");
            double result = calc.Calculation(9, 3);
            Assert.AreEqual(result, 6);
        }

        [Test]
        public void SubstracterTest2()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("-");
            double result = calc.Calculation(5, 5);
            Assert.AreEqual(result, 0);
        }

    }
}
