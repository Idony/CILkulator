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
    public class ArcsinTests
    {
        [Test]
        public void ArcsinTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("arcsin");
            double result = calc.Calculation(1);
            Assert.AreEqual(result, Math.Asin(1));
        }
        [Test]
        public void ArcsinTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("arcsin");
            double result = calc.Calculation(0.3);
            Assert.AreEqual(Math.Asin(0.3), result);
        }
    }
}
