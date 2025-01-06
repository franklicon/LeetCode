using LeetCode.Solutions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.Easy;

[TestClass]
public class MissingNumberTest
{
    [TestMethod]
    public void Test01()
    {
        // Arrange 
        var nums = new int[] { 3,0,1 };

        // Act
        var actualResult = MissingNumber.Solution(nums);

        // Assert
        Assert.AreEqual(2, actualResult);
    }
}