using NUnit.Framework;
using MyProgram;

namespace MyUnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            MyClass myClass = new MyClass();

            Assert.AreEqual("Hello World", myClass.HelloWorld());
        }
    }
}
