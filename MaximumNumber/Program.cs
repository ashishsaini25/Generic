using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestMaximum testMaximum = new TestMaximum();
            Console.Write(testMaximum.MaximumNumber("Apple", "Banana", "Peach"));
        }
    }
}
