using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class Program
    {
        /*
        #If we subtract smaller number from larger (we reduce larger number), GCD doesn’t change. 
        So if we keep subtracting repeatedly the larger of two, we end up with GCD.
        #Now instead of subtraction, if we divide smaller number, the algorithm stops when we find remainder 0. 
        */
        static long GCD(long a,long b)
        {
            return (b > 0 ? GCD(b,a%b) : a);//
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"GCD of 98 and 56 is {GCD(98, 56)}");
            Console.ReadKey();
        }
    }
}
