using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KikiKata;
namespace KikiKataTest
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void One()
        {
            Assert.AreEqual(new int[] { 1, 15, 15 }, Dinglemouse.humanYearsCatYearsDogYears(1));
        }

        [Test]
        public void Two()
        {
            Assert.AreEqual(new int[] { 2, 24, 24 }, Dinglemouse.humanYearsCatYearsDogYears(2));
        }

        [Test]
        public void Ten()
        {
            Assert.AreEqual(new int[] { 10, 56, 64 }, Dinglemouse.humanYearsCatYearsDogYears(10));
        }

    }
}
