using MaximumNumber;
using NUnit.Framework;

namespace MaximumNumberTest
{
    public class Tests
    {
        

        [Test]
        public void GivenIntegerValue_WhenCheck_ReturnMaxNum()
        {
            TestMaximum testMaximum = new TestMaximum();
            
            Assert.AreEqual(8,testMaximum.MaximumNumber(6,5,8));
        }


    }
}