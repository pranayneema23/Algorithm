using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void SelectionSort(ref int[] A)
        {
            for (int i = 0 ; i < A.Length - 1 ; i++)
            {
                int swapIndex = i;
                int min = A[i];
                for (int j = i ; j < A.Length - 1; j++)
                {
                    if (min > A[j])
                    {
                        min = A[j];
                        swapIndex = j;
                    }
                }
                int temp = A[i];
                A[i] = A[swapIndex];
                A[swapIndex] = temp;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of element");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the space seprated values");
            string inputLine = Console.ReadLine();
            string[] inputarray = inputLine.Split(' ');
            int[] A = new int[length];
            A = Array.ConvertAll(inputarray, int.Parse);
            SelectionSort(ref A);
            foreach( int val in A )
                Console.WriteLine(val);
            Console.Read();
                
        }
    }
}
