using System.Collections.Generic;
using Calc.Sorts;
using NUnit.Framework;

namespace Calc.Tests.Sort
{
    [TestFixture]
    public class PozyrekTest
    {
        [Test]
        public void PozyrekTest1()
        {
            ISort sort = SortOperationFactory.Create("Pozyrek");
            List<int> list = new List<int>() { 9, 2, 4, 3, 1 };
            List<int> result = sort.Sort(list);
            Assert.AreEqual(result, new List<int>() { 1, 2, 3, 4, 9 });
        }

        [Test]
        public void PozyrekTest2()
        {
            ISort sort = SortOperationFactory.Create("Pozyrek");
            List<int> list = new List<int>() { 9, 2, 4, 3, 1,0 };
            List<int> result = sort.Sort(list);
            Assert.AreEqual(result, new List<int>() {0, 1, 2, 3, 4, 9 });
        }
        
    }
}
