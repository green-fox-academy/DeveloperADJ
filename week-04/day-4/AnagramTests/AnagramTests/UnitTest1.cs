using NUnit.Framework;
using Anagram;

namespace AnagramTests
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase("Roma", "Roma")]
        [TestCase("RomA", "mOra")]
        [TestCase("no on", " noon")]
        [TestCase("", "")]

        public void WordsAreAnagrams(string word1, string word2)
        {
            //Arrange
            var anagramChecker = new AnagramChecker();
            //Act
            var result = anagramChecker.Compare(word1, word2);
            //Assert
            Assert.IsTrue(result);
        }

        [TestCase("Pedro", "mora")]
        [TestCase("Mark", "Handsome")]
        [TestCase("Chicken", "Dinner")]
        [TestCase("space", " space")]

        public void WordsAreNotAnagrams(string word1, string word2)
        {
            //Arrange
            var anagramChecker = new AnagramChecker();
            //Act
            var result = anagramChecker.Compare(word1, word2);
            //Assert
            Assert.IsFalse(result);
        }
    }
}
