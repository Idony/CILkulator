using Calc.BinaryCalculators;
using NUnit.Framework;

namespace Calc.Tests.BinaryCalculators
{
    [TestFixture]
    public class AdderTests
    {
        [Test]
        public void AdderTest1()
        {
            IBinaryOperation calc= BinaryOperationFactory.Create("+");
            double result = calc.Calculation(5, 6);
            Assert.AreEqual(result,11);
        }

        [Test]
        public void AdderTest2()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("+");
            double result = calc.Calculation(15, 16);
            Assert.AreEqual(31,result);
        }
    }
}
