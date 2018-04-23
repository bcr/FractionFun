using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcr.Fractions;

namespace Bcr.Fractions.Test
{
    [TestClass]
    public class FractionTest
    {
        [TestMethod]
        public void TestConstruct()
        {
            var fraction = new Fraction { Numerator = 1, Denominator = 1 };
        }
    }
}
