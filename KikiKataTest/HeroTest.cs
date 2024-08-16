using KikiKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KikiKataTest
{
    [TestFixture]
    public class Hero_Class
    {
        [Test, Description("Hero should create a Hero")]
        public void InitTest()
        {
            Hero myHero = new Hero();
            Assert.AreEqual("Hero", myHero.Name);
        }

#pragma warning disable CS0183 // Suppress specific compiler warning, asserting a strongly typed property is that type will throw a warning
        [Test, Description("Hero should have appropriate types for its properties")]
        public void TypeTest()
        {
            Hero myHero = new Hero();
            Assert.That(myHero.Health is float);
        }
#pragma warning restore CS0183
    }
}
