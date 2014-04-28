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
    public class LgTests
    {
        [Test]
        public void LgTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("lg");
            double result = calc.Calculation(2);
            Assert.AreEqual(result, Math.Log10(2));
        }
        [Test]
        public void LgTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("lg");
            double result = calc.Calculation(5);
            Assert.AreEqual(result, Math.Log10(5));
        }
    }
}
