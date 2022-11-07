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
            var expectedResult = true;

            // Act
            var actualResult = ValidAnagram.SolutionA(s, t);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test02()
        {
            // Arrange 
            var s = "ab";
            var t = "a";
            var expectedResult = false;

            // Act
            var actualResult = ValidAnagram.SolutionA(s, t);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test03()
        {
            // Arrange 
            var s = "anagram";
            var t = "nagaram";
            var expectedResult = true;

            // Act
            var actualResult = ValidAnagram.SolutionB(s, t);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Test04()
        {
            // Arrange 
            var s = "ab";
            var t = "a";
            var expectedResult = false;

            // Act
            var actualResult = ValidAnagram.SolutionB(s, t);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
