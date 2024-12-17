using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions.Easy;

namespace LeetCode.Tests.Easy
{
    [TestClass]
    public class RemoveElementTest
    {
        [TestMethod]
        public void Test01()
        {
            // Arrange
            var nums = new int[] {0, 1, 2, 2, 3, 0, 4, 2};
            var expectedNums = 5;

            // Act 
            var actualNums = RemoveElement.Solution(nums, 2);

            // Assert
            Assert.AreEqual(expectedNums, actualNums);
        }
    }
}
