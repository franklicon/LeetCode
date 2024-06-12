using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;

namespace LeetCode.Tests.Medium
{
    [TestClass]
    public class BoatsToSavePeopleTest
    {
        [TestMethod]
        public void Test01()
        {
            // Arrange
            var people = new int[] { 1, 2 };
            var limit = 3;
            var expectedResult = 1;

            // Act
            var actualResult = BoatsToSavePeople.Solution(people, limit);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test02()
        {
            // Arrange
            var people = new int[] { 3, 2, 2, 1 };
            var limit = 3;
            var expectedResult = 3;

            // Act
            var actualResult = BoatsToSavePeople.Solution(people, limit);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
