using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc.BinaryCalculators;
using Calc.SingleCalculators;
using NUnit.Framework;

namespace Calc.Tests.SingleCalculators
{
    [TestFixture]
    public class FactorialTests
    {
        [Test]
        public void FactorialTest1()
        {
            ISingleOperation calc= SingleOperationFactory.Create("n!");
            double result = calc.Calculation(5);
            Assert.AreEqual(result,120);
        }
        [Test]
        public void FactorialTest2()
        {
            ISingleOperation calc= SingleOperationFactory.Create("n!");
            double result = calc.Calculation(7);
            Assert.AreEqual(5040,result);
        }
    }
}

