using System;
using Calc.BinaryCalculators;
using NUnit.Framework;

namespace Calc.Tests.BinaryCalculators
{
    [TestFixture]
    public class ModuloTests
    {
        [Test]
        public void ModuloTest1()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("mod");
            double result = calc.Calculation(2,2);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void ModuloTest2()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("mod");
            double result = calc.Calculation(5, 5);
            Assert.AreEqual(result, 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void DeviderTest3()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("mod");
            double result = calc.Calculation(3, 0);
        }
    }
}
