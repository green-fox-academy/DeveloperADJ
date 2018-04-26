using NUnit.Framework;
using Poker;
using System.Collections.Generic;

namespace Test
{
    [TestFixture]
    public class UnitTest1
    {
        var BlackList = new List<Card>()
            {
                Card.CreateCardFromString("2H"),
                Card.CreateCardFromString("3D"),
                Card.CreateCardFromString("5S"),
                Card.CreateCardFromString("9C"),
                Card.CreateCardFromString("KD")
            };

        var WhiteList = new List<Card>()
            {
                Card.CreateCardFromString("2C"),
                Card.CreateCardFromString("3H"),
                Card.CreateCardFromString("4S"),
                Card.CreateCardFromString("8C"),
                Card.CreateCardFromString("AH")
            };

        [TestCase]
        public void Test2to10()
        {
            for (int i = 2; i <= 10; i++)
            {
                Assert.AreEqual(i, Card.CreateCardFromString($"{i}C").Value);
            }
        }

        [TestCase]
        public void TestA()
        {
            Assert.AreEqual(14, Card.CreateCardFromString($"AC").Value);
        }

        [TestCase]
        public void TestJ()
        {
            Assert.AreEqual(11, Card.CreateCardFromString($"JC").Value);
        }

        [TestCase]
        public void TestQ()
        {
            Assert.AreEqual(12, Card.CreateCardFromString($"QC").Value);
        }

        [TestCase]
        public void TestK()
        {
            Assert.AreEqual(13, Card.CreateCardFromString($"KC").Value);
        }

        [TestCase]
        public void TestHand()
        {
            Assert.AreEqual(new string[] { "2H", "3D", "5S", "9C", "KD" }, "2H 3D 5S 9C KD".Split(' '));
        }

        [TestCase]
        public void ConvertStringToHands()
        {
            var BlackList = new List<Card>()
            {
                Card.CreateCardFromString("2H"),
                Card.CreateCardFromString("3D"),
                Card.CreateCardFromString("5S"),
                Card.CreateCardFromString("9C"),
                Card.CreateCardFromString("KD")
            };

            var WhiteList = new List<Card>()
            {
                Card.CreateCardFromString("2C"),
                Card.CreateCardFromString("3H"),
                Card.CreateCardFromString("4S"),
                Card.CreateCardFromString("8C"),
                Card.CreateCardFromString("AH")
            };

            Assert.AreEqual(Card.CreateCardFromString("2H").Value, Card.CreateHandsFromString("Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C AH").Item1[0].Value);
            Assert.AreEqual(Card.CreateCardFromString("2C").Value, Card.CreateHandsFromString("Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C AH").Item2[0].Value);
        }

        [TestCase]
        public void CheckForHighCardsWhiteWins()
        {
            Assert.AreEqual("White Wins!", HandChecker.CheckForHighCard(BlackList, WhiteList));
        }
        [TestCase]
        public void CheckForAmountOfDuplicatesInHand()
        {
            //HandChecker.CountDuplicateCardsIn();
        }
    }
}
