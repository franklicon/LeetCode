using LeetCode.Solutions.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.Medium
{
    [TestClass]
    public class ProductOfArrayExceptSelfTest
    {
        [TestMethod]
        public void Test01()
        {
            // Arrange
            var nums = new int[] { 1, 2, 3, 4 };
            var expectedResult = new int[] { 24, 12, 8, 6 };

            // Act
            var result = ProductOfArrayExceptSelf.SolutionA(nums);

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test02()
        {
            // Arrange
            var nums = new int[] { 2, 3, 4, 5 };
            var expectedResult = new int[] { 60, 40, 30, 24 };

            // Act
            var result = ProductOfArrayExceptSelf.SolutionB(nums);

            // Assert
            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}
