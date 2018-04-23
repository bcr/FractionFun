using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcr.Fractions;

namespace Bcr.Fractions.Test
{
    [TestClass]
    public class ExpressionTest
    {
        [TestMethod]
        public void TestGivenCase1()
        {
            Assert.AreEqual("= 1_7/8", Expression.Evaluate("? 1/2 * 3_3/4"));
        }

        [TestMethod]
        public void TestGivenCase2()
        {
            Assert.AreEqual("= 3_1/2", Expression.Evaluate("? 2_3/8 + 9/8"));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Assert.AreEqual("= 1_7/8", Expression.Evaluate("? 1/2 * 3_3/4"));
        }

        [TestMethod]
        public void TestAddition()
        {
            Assert.AreEqual("= 3_1/2", Expression.Evaluate("? 2_3/8 + 9/8"));
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Assert.AreEqual("= 1_1/4", Expression.Evaluate("? 2_3/8 - 9/8"));
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual("= 7_1/2", Expression.Evaluate("? 3_3/4 / 1/2"));
        }
    }
}
