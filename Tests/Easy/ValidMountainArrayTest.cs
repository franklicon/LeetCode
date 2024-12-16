using LeetCode.Solutions.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.Easy;

[TestClass]
public class ValidMountainArrayTest
{
    [TestMethod]
    public void Test01()
    {
        // Arrange 
        var arr = new [] { 2, 1};

        // Act
        var result = ValidMountainArray.Solution(arr);

        // Assert
        Assert.IsFalse(result);
    }
    
    [TestMethod]
    public void Test02()
    {
        // Arrange 
        var arr = new [] { 3, 5, 5};

        // Act
        var result = ValidMountainArray.Solution(arr);

        // Assert
        Assert.IsFalse(result);
    }
    
    [TestMethod]
    public void Test03()
    {
        // Arrange 
        var arr = new [] { 0,3,2,1};

        // Act
        var result = ValidMountainArray.Solution(arr);

        // Assert
        Assert.IsTrue(result);
    }
}