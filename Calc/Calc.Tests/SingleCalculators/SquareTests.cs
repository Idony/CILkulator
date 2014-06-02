using Calc.SingleCalculators;
using NUnit.Framework;

namespace Calc.Tests.SingleCalculators
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void SquareTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("x^2");
            double result = calc.Calculation(2);
            Assert.AreEqual(result,4);
        }

        [Test]
        public void SquareTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("x^2");
            double result = calc.Calculation(3);
            Assert.AreEqual(9, result);
        }
    }
}
