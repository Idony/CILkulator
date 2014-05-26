using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc.SingleCalculators;
using NUnit.Framework;

namespace Calc.Tests.SingleCalculators
{
    [TestFixture]
    public class delxTests
    {
        [Test]
        public void delxTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("1/x");
            double result = calc.Calculation(2);
            Assert.AreEqual(result, 0.5);
        }
        [Test]
        public void delxTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("1/x");
            double result = calc.Calculation(5);
            Assert.AreEqual(0.2, result);
        }
    }
}
