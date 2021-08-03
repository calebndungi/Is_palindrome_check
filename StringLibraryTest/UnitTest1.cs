using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Is_Palindrome_Check;


namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStartsWithUpper()
        {
            // Tests that we expect to return true.
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
            foreach (var word in words)
            {
                bool result = IsPalindrome.StartsWithUpper(word);
                Assert.IsTrue(result,
                       String.Format("Expected for '{0}': true; Actual: {1}",
                                     word, result));
            }
        }

        [TestMethod]
        public void TestDoesNotStartWithUpper()
        {
            // Tests that we expect to return false.
            string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                               "1234", ".", ";", " " };
            foreach (var word in words)
            {
                bool result = IsPalindrome.StartsWithUpper(word);
                Assert.IsFalse(result,
                       String.Format("Expected for '{0}': false; Actual: {1}",
                                     word, result));
            }
        }

        [TestMethod]
        public void DirectCallWithNullOrEmpty()
        {
            // Tests that we expect to return false.
            string[] words = { string.Empty, null };
            foreach (var word in words)
            {
                bool result = IsPalindrome.StartsWithUpper(word);
                Assert.IsFalse(result,
                       String.Format("Expected for '{0}': false; Actual: {1}",
                                     word == null ? "<null>" : word, result));
            }
        }

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
    }
}
