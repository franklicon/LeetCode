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

            // Act
            var actualResult = RemoveDuplicatesFromSortedArray.Solution(nums);

            // Assert
            Assert.AreEqual(5, actualResult);
        }

        [TestMethod]
        public void Test02()
        {
            // Arrange 
            var nums = new int[] { 1, 2 };

            // Act
            var actualResult = RemoveDuplicatesFromSortedArray.Solution(nums);

            // Assert
            Assert.AreEqual(2, actualResult);
        }
        
        [TestMethod]
        public void Test03()
        {
            // Arrange 
            var nums = new int[] { 1, 1, 2, 2, 3, 4, 4, 4, 5 };

            // Act
            var actualResult = RemoveDuplicatesFromSortedArray.SolutionB(nums);

            // Assert
            Assert.AreEqual(5, actualResult);
        }

        [TestMethod]
        public void Test04()
        {
            // Arrange 
            var nums = new int[] { 1, 2 };

            // Act
            var actualResult = RemoveDuplicatesFromSortedArray.SolutionB(nums);

            // Assert
            Assert.AreEqual(2, actualResult);
        }
    }
}
