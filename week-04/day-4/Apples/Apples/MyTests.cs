using NUnit.Framework;

namespace Apples
{
    [TestFixture]
    public class MyTests
    {
        [TestCase]
        public void AppleTest()
        {
            //arrange 
            Fruit fruit = new Fruit();
            //act 

            //assert
            Assert.AreEqual("apple", fruit.GetApple());
        }
    }
}
