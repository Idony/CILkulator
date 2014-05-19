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
    public class STests
    {
        [Test]
        public void STest1()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("SRhombus");
            double result = calc.Calculation(3, 6);
            Assert.AreEqual(result, 9);
        }
        [Test]
        public void STest2()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("SRhombus");
            double result = calc.Calculation(4, 2);
            Assert.AreEqual(result, 4);
        }

    }
}
