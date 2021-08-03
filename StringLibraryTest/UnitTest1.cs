using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Is_Palindrome_Check;


namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
      
        [TestMethod]
        public void CheckRecurssive()
        {
            // tests if a string is a palindrome.
            string words = "aabaa";

            bool result = IsPalindrome.recursiveCheck(words);

            Assert.IsTrue(result, String.Format("Expected for '{0}' : true Actual: {1}", words, result));
            
        }

        [TestMethod]
        public void CheckNotRecurssive()
        {
            // tests if a string is a palindrome.
            string words = "aabana";

            bool result = IsPalindrome.recursiveCheck(words);

            Assert.IsFalse(result, String.Format("Expected for '{0}' : true Actual: {1}", words, result));

        }

        [TestMethod]
        public void CheckReverseTrue()
        {
            // tests if a string is a palindrome.
            string words = "abcba";

            bool result = IsPalindrome.reverseArray(words);

            Assert.IsTrue(result, String.Format("Expected for '{0}' : true Actual: {1}", words, result));

        }

        [TestMethod]
        public void CheckReverseFalse()
        {
            // tests if a string is a palindrome.
            string words = "abjcba";

            bool result = IsPalindrome.reverseArray(words);

            Assert.IsFalse(result, String.Format("Expected for '{0}' : true Actual: {1}", words, result));

        }

        [TestMethod]
        public void pointersCheckTrue()
        {
            // tests if a string is a palindrome.
            string words = "abcba";

            bool result = IsPalindrome.pointersCheck(words);

            Assert.IsTrue(result, String.Format("Expected for '{0}' : true Actual: {1}", words, result));

        }

        [TestMethod]
        public void pointersCheckFalse()
        {
            // tests if a string is a palindrome.
            string words = "abciba";

            bool result = IsPalindrome.pointersCheck(words);

            Assert.IsFalse(result, String.Format("Expected for '{0}' : true Actual: {1}", words, result));

        }
    }
}
