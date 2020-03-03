using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static int FindUsingBinarySearch(ref int[] A, int searchElement,int low, int high)
        {
            int mid = Convert.ToInt32((high + low) / 2);
            if (high >= low)
            {
                //return (searchElement > A[low]) ? (low + 1) : low;
                if (A[mid] == searchElement)
                    return mid;
                if (A[mid] > searchElement)
                    return FindUsingBinarySearch(ref A, searchElement, low, mid - 1);

                return FindUsingBinarySearch(ref A, searchElement, mid + 1, high);
            }
            return -1;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No. of elements");
            int length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter space separated element");
            string inputString = Console.ReadLine();
            string[] inputArray = inputString.Split(' ');
            int[] A = Array.ConvertAll(inputArray, int.Parse);
            Console.WriteLine("Enter key to find");
            int key = Int32.Parse(Console.ReadLine());
            int index = FindUsingBinarySearch(ref A, key, 0, length - 1);
            if (index > 0)
                Console.WriteLine($"Value found at index {index}");
            else
                Console.WriteLine("Element not found");
            Console.Read();
        }
    }
}
