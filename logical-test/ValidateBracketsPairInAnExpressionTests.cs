using logical_problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace logical_test
{
    [TestClass]
    public class ValidateBracketsPairInAnExpressionTests
    {
        [TestMethod]
        public void BracketPairEmptyString()
        {
            // Arrange
            Logic logic = new ValidateBracketsPairInAnExpression();

            // Act
            var result = logic.Run("");

            // Assert
            Assert.AreEqual("True", result);
        }

        [TestMethod]
        public void BracketPairValid1Pair()
        {
            // Arrange
            Logic logic = new ValidateBracketsPairInAnExpression();

            // Act
            var result = logic.Run("()");

            // Assert
            Assert.AreEqual("True", result);
        }

        [TestMethod]
        public void BracketPairInValid1PairOpen()
        {
            // Arrange
            Logic logic = new ValidateBracketsPairInAnExpression();

            // Act
            var result = logic.Run("(");

            // Assert
            Assert.AreEqual("False", result);
        }

        [TestMethod]
        public void BracketPairInValid1PairClose()
        {
            // Arrange
            Logic logic = new ValidateBracketsPairInAnExpression();

            // Act
            var result = logic.Run(")");

            // Assert
            Assert.AreEqual("False", result);
        }

        [TestMethod]
        public void BracketPairValidMultiPairs()
        {
            // Arrange
            Logic logic = new ValidateBracketsPairInAnExpression();

            // Act
            var result = logic.Run("[abc{x(y)}]");

            // Assert
            Assert.AreEqual("True", result);
        }


        [TestMethod]
        public void BracketPairInValidMultiPairs()
        {
            // Arrange
            Logic logic = new ValidateBracketsPairInAnExpression();

            // Act
            var result = logic.Run("[abcx(y)}]");

            // Assert
            Assert.AreEqual("False", result);

        }
    }
}
