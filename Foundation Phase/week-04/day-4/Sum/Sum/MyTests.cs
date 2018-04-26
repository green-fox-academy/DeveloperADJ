using NUnit.Framework;
using System.Collections.Generic;

namespace Sum
{
    [TestFixture]
    public class UnitTest1
    {

        [TestCase]
        public void SumEmpty()
        {
            List<int> operands = new List<int>();

            //arrange
            Math math = new Math();
            //act
            int summedValue = math.Sum(operands);
            //assert
            Assert.AreEqual(0, summedValue);
        }

        [TestCase]
        public void SumOne()
        {
            List<int> operands = new List<int> {1};

            //arrange
            Math math = new Math();
            //act
            int summedValue = math.Sum(operands);
            //assert
            Assert.AreEqual(1, summedValue);
        }

        [TestCase]
        public void SumMultiple()
        {
            List<int> operands = new List<int>
            {
                1,2,3,4,5
            };

            //arrange
            Math math = new Math();
            //act
            int summedValue = math.Sum(operands);
            //assert
            Assert.AreEqual(15, summedValue);
        }

        [TestCase]
        public void SumNull()
        {
            List<int> operands = null;

            //arrange
            Math math = new Math();
            //act
            int summedValue = math.Sum(operands);
            //assert
            Assert.AreEqual(0, summedValue);
        }
    }
}
