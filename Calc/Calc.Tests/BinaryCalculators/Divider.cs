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
    public class DividerTests
    {
        [Test]
        public void DeviderTest1()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("/");
            double result = calc.Calculation(14, 7);
            Assert.AreEqual(result, 2);
        }
        [Test]
        public void DeviderTest2()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("/");
            double result = calc.Calculation(25, 5);
            Assert.AreEqual(result, 5);
        }

    }
}
