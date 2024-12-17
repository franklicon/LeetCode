using LeetCode.Solutions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.Easy;

[TestClass]
public class MoveZerosTest
{
    [TestMethod]
    public void Test01()
    {
        // Arrange
        var nums = new int[] {0, 1, 2, 2, 3, 0, 4, 2};
        var expectedNums = new int[] { 1, 2, 2, 3, 4, 2, 0, 0 };

        // Act 
        MoveZeros.Solution(nums);

        // Assert
        CollectionAssert.AreEqual(expectedNums, nums);
    }
    
    [TestMethod]
    public void Test02()
    {
        // Arrange
        var nums = new int[] {0, 1, 0, 3, 12};
        var expectedNums = new int[] { 1, 3, 12, 0, 0};

        // Act 
        MoveZeros.Solution(nums);

        // Assert
        CollectionAssert.AreEqual(expectedNums, nums);
    }
}