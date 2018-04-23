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

        [TestMethod]
        public void TestFromStringBasic()
        {
            var fraction = Fraction.FromString("3/4");
            Assert.AreEqual(3, fraction.Numerator);
            Assert.AreEqual((uint) 4, fraction.Denominator);
        }

        [TestMethod]
        public void TestFromStringMixedNumber()
        {
            var fraction = Fraction.FromString("3_3/4");
            Assert.AreEqual(15, fraction.Numerator);
            Assert.AreEqual((uint) 4, fraction.Denominator);
        }
    }
}
