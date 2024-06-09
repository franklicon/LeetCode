using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;

namespace LeetCode.Tests.Medium
{
    [TestClass]
    public class ContainerWithMostWaterTest
    {
        [TestMethod]
        public void Test01()
        {
            // Arrange
            var height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var expectedResult = 49;

            // Act
            var actualResult = ContainerWithMostWater.Solution(height);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test02()
        {
            // Arrange
            var height = new int[] { 1, 1 };
            var expectedResult = 1;

            // Act
            var actualResult = ContainerWithMostWater.Solution(height);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test03()
        {
            // Arrange
            var height = new int[] { 4, 3, 2, 1, 4 };
            var expectedResult = 16;

            // Act
            var actualResult = ContainerWithMostWater.Solution(height);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test04()
        {
            // Arrange
            var height = new int[] { 1, 2, 1 };
            var expectedResult = 2;

            // Act
            var actualResult = ContainerWithMostWater.Solution(height);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
