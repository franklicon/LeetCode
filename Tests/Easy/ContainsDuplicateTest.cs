using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions.Easy;

namespace LeetCode.Tests.Easy
{
    [TestClass]
    public class ContainsDuplicateTest
    {
        [TestMethod]
        public void Test01()
        {
            // Arrange 
            var nums = new int[] { 1, 2, 3, 4 };
            var expectedResult = false;

            // Act
            var actualResult = ContainsDuplicate.Solution(nums);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
