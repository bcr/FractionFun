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

        [TestMethod]
        public void TestOneOrMoreSpaces()
        {
            // Operands and operators shall be separated by one or more spaces.
            Assert.AreEqual("= 1_7/8", Expression.Evaluate("?     1/2      *     3_3/4"));
        }

        // Now we start getting into the fuzzy area of "incorrect input". How
        // do we try to predict what kind of cheese sandwich someone might
        // enter and expect something good to happen.
        //
        // "Legal operators shall be *, /, +, - (multiply, divide, add,
        // subtract)."
        //
        // What good does it do to tell the user "invalid operator"? It says
        // in the instructions what the valid operators are. Why did they type
        // an invalid operator? What if we complain about "invalid operator"
        // and it's because they typed "? 3 1/2 * 1/4". Now we complained 
        // about the operator, but what's really wrong is the format of the
        // mixed number.
        //
        // Madness lies on this path.
        //
        // How much exception data should be presented? Can the user try and
        // piece together what went wrong from a backtrace?
        //
        // And the only place we will end up is a complaint that the user has
        // to interpret and act upon.
        //
        // So my opinion is to catch all the exceptions that fly out of
        // Evaluate and say "Invalid input, please consult the instructions."

        [TestMethod]
        public void TestBadOperator()
        {
            Assert.AreEqual("Invalid input, please consult the instructions.", Expression.Evaluate("? 1/2 % 3_3/4"));
        }
    }
}
