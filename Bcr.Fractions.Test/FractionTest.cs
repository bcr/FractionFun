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

        public void AreEqualAndUnequal<T>(T first, T equal, T unequal)
        {
            Assert.AreEqual(first, equal);
            Assert.AreNotEqual(first, unequal);
            Assert.AreEqual(first.GetHashCode(), equal.GetHashCode());
        }

        [TestMethod]
        public void TestFromStringBasic()
        {
            var fraction = Fraction.FromString("3/4");
            Assert.AreEqual(fraction, new Fraction { Numerator = 3, Denominator = 4 });
        }

        [TestMethod]
        public void TestFromStringMixedNumber()
        {
            var fraction = Fraction.FromString("3_3/4");
            Assert.AreEqual(fraction, new Fraction { Numerator = 15, Denominator = 4 });
        }

        [TestMethod]
        public void TestFromStringWholeNumber()
        {
            var fraction = Fraction.FromString("3");
            Assert.AreEqual(fraction, new Fraction { Numerator = 3, Denominator = 1 });
        }

        [TestMethod]
        public void TestAreEqualAndUnequal()
        {
            AreEqualAndUnequal("a", "a", "b");
        }

        [TestMethod]
        public void TestFractionEquality()
        {
            var fraction = new Fraction { Numerator = 1, Denominator = 4 };
            var equalFraction = new Fraction { Numerator = 1, Denominator = 4 };
            var unequalFraction = new Fraction { Numerator = 1, Denominator = 5 };

            AreEqualAndUnequal(fraction, equalFraction, unequalFraction);
        }

        [TestMethod]
        public void TestToString()
        {
            Assert.AreEqual("1/4", new Fraction { Numerator = 1, Denominator = 4 }.ToString());
        }

        [TestMethod]
        public void TestMixedNumberToString()
        {
            Assert.AreEqual("1_1/4", new Fraction { Numerator = 5, Denominator = 4 }.ToString());
        }

        [TestMethod]
        public void TestWholeNumberToString()
        {
            Assert.AreEqual("5", new Fraction { Numerator = 5, Denominator = 1 }.ToString());
        }
    }
}
