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
    public class PowerTests
    {
        [Test]
        public void PowerTest1()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("x^y");
            double result = calc.Calculation(2, 3);
            Assert.AreEqual(result, 8);
        }
        [Test]
        public void PowerTest2()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("x^y");
            double result = calc.Calculation(5, 2);
            Assert.AreEqual(result, 25);
        }

    }
}
