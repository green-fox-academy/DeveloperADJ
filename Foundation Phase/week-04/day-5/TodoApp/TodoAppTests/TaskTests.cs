using NUnit.Framework;
using TodoApp;

namespace TodoAppTests
{
    [TestFixture]
    class TaskTests
    {
        [TestCase]
        public void TaskShouldHaveName()
        {
            Task task = new Task("Buy Milk");

            Assert.AreEqual("Buy Milk", task.text);
        }

        [TestCase(false)]
        public void TaskBoolShouldBeFalse(bool completed)
        {
            Task task = new Task("Buy Milk", completed);

            Assert.AreEqual(false, task.isCompleted);
        }

        [TestCase]
        public void TaskBoolShouldBeFalseByDefault()
        {
            Task task = new Task("Buy Milk");

            Assert.AreEqual(false, task.isCompleted);
        }

        [TestCase(true)]
        public void TaskBoolShouldBeTrue(bool completed)
        {
            Task task = new Task("Buy Milk", completed);

            Assert.AreEqual(true, task.isCompleted);
        }
    }
}
