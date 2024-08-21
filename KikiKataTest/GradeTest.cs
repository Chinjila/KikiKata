using KikiKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KikiKataTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(0.7, ExpectedResult = 'C')]
        [TestCase(0.9, ExpectedResult = 'A')]
        [TestCase(0.6, ExpectedResult = 'D')]
        public static char FixedTest(double score)
        {
            return Grade.Grader(score);
        }
    }
}
