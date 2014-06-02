using Calc.BinaryCalculators;
using NUnit.Framework;

namespace Calc.Tests.BinaryCalculators
{
    [TestFixture]
    public class RankTests
    {
        [Test]
        public void RankTest1()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("rank");
            double result = calc.Calculation(123456, 5);
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void RankTest2()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("rank");
            double result = calc.Calculation(557423, 4);
            Assert.AreEqual(result, 7);
        }

    }
}
