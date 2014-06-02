using Calc.BinaryCalculators;
using NUnit.Framework;

namespace Calc.Tests.BinaryCalculators
{
    [TestFixture]
    public class MultiplierTests
    {
        [Test]
        public void MultiplierTest1()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("*");
            double result = calc.Calculation(9, 3);
            Assert.AreEqual(result, 27);
        }

        [Test]
        public void MultiplierTest2()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("*");
            double result = calc.Calculation(5, 5);
            Assert.AreEqual(result, 25);
        }

    }
}
