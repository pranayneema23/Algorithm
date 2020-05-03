using System;
namespace Recursion
{
    class LongestIncreasingSubsequence_RecursionWithMemoization
    {
        public static int[,] memo;
        public static int lengthOfLIS(int[] arr)
        {
            memo = new int[arr.Length+1,arr.Length];
            // for(int i=0;i<arr.Length+1;i++)
            // {
            //     for(int j=0;j<arr.Length;j++)
            //         memo[i,j] = -1;
            // }
            return lengthOfLIS(arr,-1,0,memo);
        }
        public static int lengthOfLIS(int[] arr,int previousIndex,int currentPosition,int[,] memo)
        {
            //If current position is exceed the array index
            if(currentPosition == arr.Length)
                return 0;
            //If we aready computed the LIS without including previousInclude a
            if(memo[previousIndex + 1,currentPosition] > 0)
                return memo[previousIndex + 1,currentPosition];
            
            int ifCurrentPositionTaken = 0;
            if(previousIndex < 0 || arr[currentPosition] > arr[previousIndex])
                ifCurrentPositionTaken = 1 + lengthOfLIS(arr, currentPosition, currentPosition+1,memo);
            
            int ifCurrentPositionNotTaken = lengthOfLIS(arr, previousIndex, currentPosition+1,memo);

            memo[previousIndex + 1,currentPosition] = Math.Max(ifCurrentPositionTaken,ifCurrentPositionNotTaken);
            return memo[previousIndex + 1,currentPosition];
        }
        public static void Main()
        {
            Console.WriteLine("Enter the length of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            A = Array.ConvertAll(Console.ReadLine().Split(' '),a => int.Parse(a));
            Console.WriteLine("Length of largest increasing subsequence is : " + lengthOfLIS(A));
            //Code to print memo array            
            Console.WriteLine("Memo array content is :-");
            for(int i=0;i<A.Length+1;i++)
            {
                for(int j=0;j<A.Length;j++)
                    Console.Write(memo[i,j] + " ");
                Console.WriteLine("\n");
            }
        }
    }
    //Source : https://leetcode.com/problems/longest-increasing-subsequence/solution/
}