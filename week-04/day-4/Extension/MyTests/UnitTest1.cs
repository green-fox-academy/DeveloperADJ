using NUnit.Framework;
using System.Collections.Generic;

namespace Extension
{
    [TestFixture]
    public class ExtensionTests
    {
        Extension extension = new Extension();

        [Test]
        public void TestAdd_2and3is5()
        {
            Assert.AreEqual(5, extension.Add(2, 3));
            Assert.AreEqual(10, extension.Add(5, 5));
        }

        [Test]
        public void TestAdd_1and4is5()
        {
            Assert.AreEqual(5, extension.Add(1, 4));
            Assert.AreEqual(14, extension.Add(7, 7));
        }

        [Test]
        public void TestMaxOfThree_First()
        {
            Assert.AreEqual(5, extension.MaxOfThree(5, 4, 3));
            Assert.AreEqual(10, extension.MaxOfThree(5, 10, 3));
        }

        [Test]
        public void TestMaxOfThree_Fhird()
        {
            Assert.AreEqual(5, extension.MaxOfThree(3, 4, 5));
            Assert.AreEqual(10, extension.MaxOfThree(3, 10, 5));

        }

        [Test]
        public void TestMedian_Four()
        {
            Assert.AreEqual(5, extension.Median(new List<int>() { 7, 5, 3, 5 }));
            Assert.AreEqual(5, extension.Median(new List<int>() { 2, 4, 6, 8 }));
        }

        [Test]
        public void TestMedian_Five()
        {
            Assert.AreEqual(3, extension.Median(new List<int>() { 1, 2, 3, 4, 5 }));
        }

        [Test]
        public void TestIsVowel_a()
        {
            Assert.True(extension.IsVowel('a'));
        }

        [Test]
        public void TestIsVowel_u()
        {
            Assert.True(extension.IsVowel('u'));
        }

        [Test]
        public void testTranslate_bemutatkozik()
        {
            Assert.AreEqual("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
        }

        [Test]
        public void testTranslate_kolbice()
        {
            Assert.AreEqual("lavagovopuvus", extension.Translate("lagopus"));
        }
    }
}