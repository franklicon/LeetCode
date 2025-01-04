using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;

namespace LeetCode.Tests.Medium;

[TestClass]
public class FindFirstAndLastPositionOfElementInSortedArrayTest
{
    [TestMethod]
    public void Test01()
    {
        // Arrange
        var nums = new int[] { 5, 7, 7, 8, 8, 10 };
        var target = 8;
        var expectedResult = new int[] { 3, 4 };

        // Act
        var result = FindFirstAndLastPositionOfElementInSortedArray.Solution(nums, target);

        // Assert
        CollectionAssert.AreEqual(expectedResult, result);
    }
    
    [TestMethod]
    public void Test02()
    {
        // Arrange
        var nums = new int[] { 5, 7, 7, 8, 8, 10 };
        var target = 6;
        var expectedResult = new int[] { -1, -1 };

        // Act
        var result = FindFirstAndLastPositionOfElementInSortedArray.Solution(nums, target);

        // Assert
        CollectionAssert.AreEqual(expectedResult, result);
    }
}