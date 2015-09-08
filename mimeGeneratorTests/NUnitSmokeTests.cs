using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace NUnitSmokeTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void TestAdd2by3()
        {
            int result = NUnitSmoke.Calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}