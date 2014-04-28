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
    public class Arctg
    {
        [Test]
        public void ArctgTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("arctg");
            double result = calc.Calculation(2);
            Assert.AreEqual(result, Math.Atan(2));
        }
        [Test]
        public void ArctgTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("arctg");
            double result = calc.Calculation(3);
            Assert.AreEqual(Math.Atan(3), result);
        }
    }
}