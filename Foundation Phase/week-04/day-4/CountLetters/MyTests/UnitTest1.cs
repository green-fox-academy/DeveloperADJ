using NUnit.Framework;
using CountLetters;
using System.Collections.Generic;

namespace MyTests
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void GreenfoxLetterCounter()
        {
            Letters letters = new Letters();

            var greenfox = new Dictionary<string, int>
            {
                { "g", 1 },
                { "r", 1 },
                { "e", 2 },
                { "n", 1 },
                { "f", 1 },
                { "o", 1 },
                { "x", 1 }
            };

            Assert.AreEqual(greenfox, letters.CountInDictionary("greenfox"));
        }

        [TestCase]
        public void BluebeardLetterCounter()
        {
            Letters letters = new Letters();

            var bluebeard = new Dictionary<string, int>
            {
                { "b", 2 },
                { "l", 1 },
                { "u", 1 },
                { "e", 2 },
                { "a", 1 },
                { "r", 1 },
                { "d", 1 }
            };

            Assert.AreEqual(bluebeard, letters.CountInDictionary("bluebeard"));
        }

        [TestCase(1, "arno", "a")]
        [TestCase(2, "miki", "i")]
        [TestCase(2, "david", "d")]
        [TestCase(2, "fanni", "n")]
        public void CheckLetterCounters(int count, string word, string character)
        {
            Letters letters = new Letters();

            Assert.AreEqual(count, letters.CountInDictionary(word)[character]);
        }
    }
}

