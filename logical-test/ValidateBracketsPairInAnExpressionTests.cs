using logical_problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace logical_test
{
    [TestClass]
    public class ValidateBracketsPairInAnExpressionTests
    {
        [TestMethod]
        public void EmptyString()
        {
            // Arrange
            Logic logic = new ValidateBracketsPairInAnExpression();

            // Act
            var result = logic.Run("");

            // Assert
            Assert.AreEqual("True", result);
        }

        [TestMethod]
        public void Valid1Pair()
        {
            // Arrange
            Logic logic = new ValidateBracketsPairInAnExpression();

            // Act
            var result = logic.Run("()");

            // Assert
            Assert.AreEqual("True", result);
        }

        [TestMethod]
        public void InValid1PairOpen()
        {
            // Arrange
            Logic logic = new ValidateBracketsPairInAnExpression();

            // Act
            var result = logic.Run("(");

            // Assert
            Assert.AreEqual("False", result);
        }

        [TestMethod]
        public void InValid1PairClose()
        {
            // Arrange
            Logic logic = new ValidateBracketsPairInAnExpression();

            // Act
            var result = logic.Run(")");

            // Assert
            Assert.AreEqual("False", result);
        }

        [TestMethod]
        public void ValidMultiPairs()
        {
            // Arrange
            Logic logic = new ValidateBracketsPairInAnExpression();

            // Act
            var result = logic.Run("[abc{x(y)}]");

            // Assert
            Assert.AreEqual("True", result);
        }


        [TestMethod]
        public void InValidMultiPairs()
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
