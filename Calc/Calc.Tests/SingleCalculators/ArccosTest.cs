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
    public class ArccosTests
    {
        [Test]
        public void ArcsinTest1()
        {
            ISingleOperation calc = SingleOperationFactory.Create("arccos");
            double result = calc.Calculation(0.5);
            Assert.AreEqual(result, Math.Acos(0.5));
        }

        [Test]
        public void ArccosTest2()
        {
            ISingleOperation calc = SingleOperationFactory.Create("arccos");
            double result = calc.Calculation(0.3);
            Assert.AreEqual(result, Math.Acos(0.3));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ArccosFailTest()
        {
            ISingleOperation calc = SingleOperationFactory.Create("arccos");
            double result = calc.Calculation(-2);
        }
    }
}
