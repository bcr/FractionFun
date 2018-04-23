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
    }
}
