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
    public class CubedTests
    {
        [Test]
        public void CubedTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("x^3");
            double result = calc.Calculation(2);
            Assert.AreEqual(result, 8);
        }
        [Test]
        public void CubedTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("x^3");
            double result = calc.Calculation(3);
            Assert.AreEqual(27, result);
        }
    }
}
