using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc.BinaryCalculators;
using NUnit.Framework;

namespace Calc.Tests.BinaryCalculators
{
    [TestFixture]
    public class PowerSqrtTests
    {
        [Test]
        public void PowerSqrtTest1()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("x^(1/y)");
            double result = calc.Calculation(2, 2);
            Assert.AreEqual(result, 1, 4142135623731);
        }
        [Test]
        public void PowerSqrtTest2()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("x^(1/y)");
            double result = calc.Calculation(4, 2);
            Assert.AreEqual(result, 2);
        }

    }
}
