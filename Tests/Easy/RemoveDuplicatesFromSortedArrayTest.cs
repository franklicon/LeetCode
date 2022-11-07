using LeetCode.Solutions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.Easy
{
    [TestClass]
    public class RemoveDuplicatesFromSortedArrayTest
    {
        [TestMethod]
        public void Test01()
        {
            // Arrange 
            var nums = new int[] { 1, 1, 2, 2, 3, 4, 4, 4, 5 };
            var expectedResult = 5;

            // Act
            var actualResult = RemoveDuplicatesFromSortedArray.Solution(nums);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test02()
        {
            // Arrange 
            var nums = new int[] { 1, 2 };
            var expectedResult = 2;

            // Act
            var actualResult = RemoveDuplicatesFromSortedArray.Solution(nums);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
