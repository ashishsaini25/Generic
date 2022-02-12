using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    public class TestMaximum<T> where T:IComparable
    {

        public   T MaximumNumber( T firstnumber ,T secondnumber, T thirdnumber, [Optional] T fourthNUmber )
        {


            if (firstnumber.CompareTo(secondnumber) > 0 && firstnumber.CompareTo(thirdnumber) > 0&&firstnumber.CompareTo(fourthNUmber)>0) return firstnumber;

            if (secondnumber.CompareTo(firstnumber) > 0 && secondnumber.CompareTo(thirdnumber) > 0&&secondnumber.CompareTo(fourthNUmber)>0) return secondnumber;

            if (thirdnumber.CompareTo(firstnumber) > 0 && thirdnumber.CompareTo(secondnumber) > 0 && thirdnumber.CompareTo(fourthNUmber) > 0)
                return thirdnumber;
            else
                return fourthNUmber;

        }

    }
}
