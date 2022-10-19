using LeetCode.Solutions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.Easy
{
    [TestClass]
    public class SingleNumberTest
    {
        [TestMethod] 
        public void TestA01()
        {
            // Arrange 
            var nums = new int[] { 1, 1, 2, 5, 2 };
            var expectedResult = 5;

            // Act
            var actualResult = SingleNumber.SolutionA(nums);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestB01()
        {
            // Arrange 
            var nums = new int[] { 1, 1, 2, 5, 2 };
            var expectedResult = 5;

            // Act
            var actualResult = SingleNumber.SolutionB(nums);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
