using System;
using WordCount;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionsTests
{
    [TestClass]
    public class WordCountTest
    {
        WordCounter _target = new WordCounter();

        [TestMethod]
        public void CountLines_3lines_Returns3()
        {
            string testText = "1 sentence \n 2 sentence \n and third sentences";

            Assert.AreEqual(3, _target.CountLines(testText));
        }

        [TestMethod]
        public void CountWords_5Words_Returns5()
        {
            string testText = "first word isn't last";

            Assert.AreEqual(5, _target.CountWords(testText));
        }

        [TestMethod]
        public void CountCharacters_10characters_Returns10()
        {
            string testText = "12345 789.";

            Assert.AreEqual(10, _target.CountCharacters(testText));
        }

        [TestMethod]
        public void CountWords_emptyString_Returns0()
        {
            Assert.AreEqual(0, _target.CountWords(""));
        }

        [TestMethod]
        public void CountLines_emptyString_Returns0()
        {
            Assert.AreEqual(0, _target.CountLines(""));
        }

        [TestMethod]
        public void CountCharacters_emptyString_Returns0()
        {
            Assert.AreEqual(0, _target.CountCharacters(""));
        }

        [TestMethod]
        public void CountWords_null_Returns0()
        {
            Assert.AreEqual(0, _target.CountWords(null));
        }

        [TestMethod]
        public void CountLines_null_Returns0()
        {
            Assert.AreEqual(0, _target.CountLines(null));
        }

        [TestMethod]
        public void CountCharacters_null_Returns0()
        {
            Assert.AreEqual(0, _target.CountCharacters(null));
        }


    }
}
