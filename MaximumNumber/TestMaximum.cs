using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    public class TestMaximum<T> where T : IComparable
    {
        public T firstnumber, secondnumber, thirdnumber,fourthnumber;
        public TestMaximum(T firstnumber, T secondnumber, T thirdnumber, [Optional] T fourthNUmber)
        {
            this.firstnumber = firstnumber;
            this.secondnumber = secondnumber;
             this.thirdnumber = thirdnumber;
             this.fourthnumber=fourthNUmber;            
            }

        public   T MaximumNumber(  )
        {


            if (this.firstnumber.CompareTo(secondnumber) > 0 && this.firstnumber.CompareTo(thirdnumber) > 0&&this.firstnumber.CompareTo(this.fourthnumber)>0) return this.firstnumber;

            if (this.secondnumber.CompareTo(firstnumber) > 0 && this.secondnumber.CompareTo(thirdnumber) > 0&&this.secondnumber.CompareTo(this.fourthnumber)>0) return this.secondnumber;

            if (this.thirdnumber.CompareTo(firstnumber) > 0 && this.thirdnumber.CompareTo(secondnumber) > 0 && this.thirdnumber.CompareTo(this.fourthnumber) > 0)
                return this.thirdnumber;
            else
                return this.fourthnumber;
         }
        public void Print(T var)
        {
           
            Console.WriteLine(var);
        }

    }
}
