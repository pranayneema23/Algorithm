using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    public class HeapSort
    {
        public void Sort(int[] arr)
        {
            int arrSize = arr.Length;

            //Build Heap(rearrange array)
            for(int i = arrSize/2 - 1;i >=0; i--)
                Heapify(arr,arrSize,i);


            for(int i=arrSize-1;i >= 0; i--)
            {
                /*arr[0] = arr[0] ^ a
                 * rr[i];
                arr[i] = arr[0] ^ arr[i];
                arr[0] = arr[0] ^ arr[i];*/
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
        }

        void Heapify(int[] arr, int arraySize, int index)
        {
            int largest = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;

            if (left < arraySize && arr[left] > arr[largest])
                largest = left;

            if (right < arraySize && arr[right] > arr[largest])
                largest = right;

            if (largest != index)
            {
                /*arr[index] = arr[index] ^ arr[largest];
                arr[largest] = arr[index] ^ arr[largest];
                arr[index] = arr[index] ^ arr[largest];*/
                int swap = arr[index];
                arr[index] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, arraySize, largest);
            }
        }
    }

    class Program
    {
        public static void PrintArray(int[] arr)
        {
            foreach (int val in arr)
                Console.WriteLine(val);
            Console.Read();
        }

        static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            int arrSize = arr.Length;
            HeapSort hs = new HeapSort();
            hs.Sort(arr);
            PrintArray(arr);
        }
    }
}
