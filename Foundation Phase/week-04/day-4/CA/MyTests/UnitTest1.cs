using NUnit.Framework;
using CA;

namespace MyTests
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            //Arrange
            Tree tree = new Tree("Tree", 0.4, 100);

            //Act
            string name = tree.GetName();

            //Assert
            Assert.AreEqual("Tree", name);
        }
    }
}
