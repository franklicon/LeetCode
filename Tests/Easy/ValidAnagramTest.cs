using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Solutions.Easy;

namespace LeetCode.Tests.Easy
{
    [TestClass]
    public class ValidAnagramTest
    {
        [TestMethod]
        public void Test01()
        {
            // Arrange 
            var s = "anagram";
            var t = "nagaram";

            // Act
            var result = ValidAnagram.SolutionA(s, t);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test02()
        {
            // Arrange 
            var s = "ab";
            var t = "a";

            // Act
            var result = ValidAnagram.SolutionA(s, t);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test03()
        {
            // Arrange 
            var s = "anagram";
            var t = "nagaram";

            // Act
            var result = ValidAnagram.SolutionB(s, t);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test04()
        {
            // Arrange 
            var s = "ab";
            var t = "a";

            // Act
            var result = ValidAnagram.SolutionB(s, t);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
