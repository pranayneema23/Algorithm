using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Swap(ref int[] A,int i,int j)
        {
            A[i] = A[i] - A[j];
            A[j] = A[j] + A[i];
            A[i] = A[j] - A[i];
        }

        static void BubbleSort(ref int[] A)
        {
			bool IsAnySwap = false;
            for(int i = 0; i < A.Length; i++)
            {
                for(int j = 0; j < A.Length - i - 1; j++)
                {
                    if(A[j] > A[j+1])
                    {
                        Swap(ref A,j,j+1);
						IsAnySwap = true;
                    }
                }
				if(! IsAnySwap)
                {
                    Console.WriteLine("Element already sorted");
                    break;
                }
					
            }
        }

        static void Main(string[] args)
        {
            int length;
            Console.WriteLine("Enter no of element");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter space separated element");
            string inputLine = Console.ReadLine();
            string[] arrInput = inputLine.Split(' ');
            int[] A = Array.ConvertAll(arrInput, int.Parse);
            BubbleSort(ref A);
            foreach (var val in A)
                Console.WriteLine(val);
            Console.ReadKey();
        }
    }
}
