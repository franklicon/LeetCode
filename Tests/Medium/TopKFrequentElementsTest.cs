using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions.Medium;

namespace LeetCode.Tests.Medium
{
    [TestClass]
    public class TopKFrequentElementsTest
    {
        [TestMethod]
        public void Test01()
        {
            // Arrange
            var nums = new int[] { 1, 1, 1, 2, 2, 3 };
            var k = 2;
            var expectedResult = new int[] { 1, 2 };

            // Act
            var actualResult = TopKFrequentElements.SolutionA(nums, k);

            // Assert
            CollectionAssert.AreEquivalent(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test02()
        {
            // Arrange
            var nums = new int[] { 1, 1, 1, 2, 2, 3, 3, 3, 3, 4, 5, 5, 5, 5, 5 };
            var k = 3;
            var expectedResult = new int[] { 1, 3, 5 };

            // Act
            var actualResult = TopKFrequentElements.SolutionA(nums, k);

            // Assert
            CollectionAssert.AreEquivalent(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test03()
        {
            // Arrange
            var nums = new int[] { 1, 1, 1, 2, 2, 3 };
            var k = 2;
            var expectedResult = new int[] { 1, 2 };

            // Act
            var actualResult = TopKFrequentElements.SolutionB(nums, k);

            // Assert
            CollectionAssert.AreEquivalent(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test04()
        {
            // Arrange
            var nums = new int[] { 1, 1, 1, 2, 2, 3, 3, 3, 3, 4, 5, 5, 5, 5, 5 };
            var k = 3;
            var expectedResult = new int[] { 1, 3, 5 };

            // Act
            var actualResult = TopKFrequentElements.SolutionB(nums, k);

            // Assert
            CollectionAssert.AreEquivalent(expectedResult, actualResult);
        }
    }
}
