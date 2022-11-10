using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Easy;

namespace Tests.Easy
{
    [TestClass]
    public class FindNearestPointThatHasTheSameXOrYCoordinateTest
    {
        [TestMethod]
        public void Test01()
        {
            // Arrange
            var points = new int[][] { 
                new int[] { 1, 2 },
                new int[] { 3, 1 },
                new int[] { 2, 4 },
                new int[] { 2, 3 },
                new int[] { 4, 4 },
            };
            var x = 3;
            var y = 4;
            var expectedResult = 2;

            // Act
            var actualResult = FindNearestPointThatHasTheSameXOrYCoordinate.Solution(x, y, points);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
