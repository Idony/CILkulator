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
    public class SwapTests
    {
        [Test]
        public void SwapTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("+/-");
            double result = calc.Calculation(5);
            Assert.AreEqual(result,(-5));
        }
        [Test]
        public void SwapTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("+/-");
            double result = calc.Calculation(-3);
            Assert.AreEqual(result, (3));
        }
    }
}
