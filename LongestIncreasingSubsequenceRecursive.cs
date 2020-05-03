using System;
namespace Recursion
{
    //Time Complexity : O(2^n)
	//Space Complexity : O(2^n) (for recursivr stack)
    class LongestIncreasingSubsequenceRecursive
    {
        public static int lengthOfLIS(int[] arr)
        {
            return lengthOfLIS(arr,Int16.MinValue,0);
        }
        public static int lengthOfLIS(int[] arr,int previusIncludeElement,int currentPosition)
        {
            if(currentPosition == arr.Length)
                return 0;
            
            int ifCurrentPositionTaken = 0;
            if(arr[currentPosition] > previusIncludeElement)
                ifCurrentPositionTaken = 1 + lengthOfLIS(arr, arr[currentPosition], currentPosition+1);
            
            int ifCurrentPositionNotTaken = lengthOfLIS(arr, previusIncludeElement, currentPosition+1);

            return Math.Max(ifCurrentPositionTaken,ifCurrentPositionNotTaken);
        }
        public static void Main()
        {
            Console.WriteLine("Enter the length of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            A = Array.ConvertAll(Console.ReadLine().Split(' '),a => int.Parse(a));
            Console.WriteLine("Length of largest increasing subsequence is : " + lengthOfLIS(A));
        }
    }
    //Source : https://leetcode.com/problems/longest-increasing-subsequence/solution/
}