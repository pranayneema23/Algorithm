using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadanes_Algo
{  
    class Program
    {
        static int[] KadanesAlgo(int[] arr)//Algo to compute MaxSumSubArray
        {
            int[] result = new int[3];
            //Index 1 : start index
            //Index 2 : end index
            //Index 3 : value of max sum
            //int n = arr.Length;//Length of array
            int local_max = 0,global_max = Int32.MinValue;
            int start_index = 0, end_index = 0,i = 0;
            foreach(int a in arr)
            {
                int maxOfTwo = Math.Max(a, a + local_max);
                if (maxOfTwo == a)
                    start_index = i;
                local_max = Math.Max(a, a + local_max);
                if (local_max > global_max)
                {
                    global_max = local_max;
                    end_index = i;
                }
                i++;
            }

            //Set result array
            result[0] = start_index;
            result[1] = end_index;
            result[2] = global_max;

            return result;
        }
        static void Main(string[] args)
        {
            int length;
            Console.WriteLine("Enter total no of elements");
            length = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[length];
            Console.WriteLine("Enter elements : ");
            for(int i=0; i < A.Length;i++ )
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = new int[3];
            result = KadanesAlgo(A);
            Console.WriteLine($"The start index is {result[0]}, end index is {result[1]} and max sum is {result[2]}");
            Console.ReadLine();
        }
    }
}
