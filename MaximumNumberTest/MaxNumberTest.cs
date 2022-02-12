using MaximumNumber;
using NUnit.Framework;

namespace MaximumNumberTest
{
    public class Tests
    {
        TestMaximum<int> testmaximumint = new TestMaximum<int>();
        TestMaximum<float> testmaximumfloat = new TestMaximum<float>();
        TestMaximum<string> testmaximumstring = new TestMaximum<string>();


        [Test]
        public void GivenIntegerValue_WhenCheck_ReturnMaxNum()
        {
            
            int max =testmaximumint.MaximumNumber(1, 2, 3);

            Assert.AreEqual(3, max);
        }
        [Test]
        public void GivenStringValue_WhenCheck_ReturnMaxString()
        {
            
            string max = testmaximumstring.MaximumNumber("Apple", "Banana", "Peach");

            Assert.AreEqual("Peach", max);
        }


        [Test]
        public void GivenFloatValue_WhenCheck_ReturnMaxNum()
        {
           
            float max = testmaximumfloat.MaximumNumber(1.1f, 2.2f, 3.3f);
            
            Assert.AreEqual(3.3f,max);
        }
       




    }
}