using logical_problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace logical_test
{
    [TestClass]
    public class SearchBiggestPalindromeInStringTests
    {
        [TestMethod]
        public void SearchForBiggest()
        {
            // Arrange
            Logic logic = new SearchBiggestPalindromeInString();

            // Act
            var result = logic.Run("nitinspeaksmalayalam");

            // Assert
            Assert.AreEqual("malayalam", result);
        }

        [TestMethod]
        public void SearchFor2SameSize()
        {
            // Arrange
            Logic logic = new SearchBiggestPalindromeInString();

            // Act
            var result = logic.Run("nitinsalas");

            // Assert
            Assert.AreEqual("nitin,salas", result);
        }

        [TestMethod]
        public void SearchForNoPalindrome()
        {
            // Arrange
            Logic logic = new SearchBiggestPalindromeInString();

            // Act
            var result = logic.Run("abc");

            // Assert
            Assert.AreEqual("a,b,c", result);
        }
    }
}
