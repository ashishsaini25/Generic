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
            
            Assert.AreEqual(6.7,testMaximum.MaximumNumber(2.8,3.4,6.7));
        }


    }
}