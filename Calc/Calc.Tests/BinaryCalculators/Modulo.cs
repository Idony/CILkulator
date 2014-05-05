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
    public class ModuloTests
    {
        [Test]
        public void ModuloTest1()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("mod");
            double result = calc.Calculation(2,2);
            Assert.AreEqual(result, 0);
        }
        [Test]
        public void ModuloTest2()
        {
            IBinaryOperation calc = BinaryOperationFactory.Create("mod");
            double result = calc.Calculation(5, 5);
            Assert.AreEqual(result, 0);
        }

    }
}
