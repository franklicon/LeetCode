using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solutions.Medium;

namespace LeetCode.Tests.Medium;

[TestClass]
public class LongestSubstringWithoutRepeatingCharactersTest
{
    [TestMethod]
    public void Test01()
    {
        // Arrange
        var s = "pwwkew";

        // Act
        var result = LongestSubstringWithoutRepeatingCharacters.Solution(s);

        // Assert
        Assert.AreEqual(3, result);
    }
    
    [TestMethod]
    public void Test02()
    {
        // Arrange
        var s = "abcabcbb";

        // Act
        var result = LongestSubstringWithoutRepeatingCharacters.Solution(s);

        // Assert
        Assert.AreEqual(3, result);
    }
}