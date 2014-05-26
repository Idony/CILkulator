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
    public class lnTests
    {
        [Test]
        public void LnTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("ln");
            double result = calc.Calculation(1);
            Assert.AreEqual(result, 0 );
        }
        [Test]
        public void LnTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("ln");
            double result = calc.Calculation(Math.Pow(Math.E, 2));
            Assert.AreEqual(2, result);
        }
    }
}
