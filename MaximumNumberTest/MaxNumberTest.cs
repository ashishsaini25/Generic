using MaximumNumber;
using NUnit.Framework;

namespace MaximumNumberTest
{
    public class Tests
    {
        TestMaximum<int> testmaximumint = new TestMaximum<int>(1, 2, 3, 4);
        TestMaximum<float> testmaximumfloat = new TestMaximum<float>(1.1f, 2.2f, 3.3f);
        TestMaximum<string> testmaximumstring = new TestMaximum<string>("Apple", "Banana", "Peach", "Mango");


        [Test]
        public void GivenIntegerValue_WhenCheck_ReturnMaxNum()
        {
            
            int max =testmaximumint.MaximumNumber();
            Assert.AreEqual(4, max);
            testmaximumint.Print(max);
        }
        [Test]
        public void GivenStringValue_WhenCheck_ReturnMaxString()
        {
            
            string max = testmaximumstring.MaximumNumber();
            Assert.AreEqual("Peach", max);
            testmaximumstring.Print(max);
;        }


        [Test]
        public void GivenFloatValue_WhenCheck_ReturnMaxNum()
        {
           
            float max = testmaximumfloat.MaximumNumber();
         
            Assert.AreEqual(3.3f,max);
            testmaximumfloat.Print(max);
        }
       




    }
}