using System;
namespace Recursion
{
	//Time Complexity : O(n)
	//Space Complexity : O(n) (for recursivr stack)
	class IsArraySorted
	{
		public static int IsSorted(int n,int[] A)
		{
			if(n == 1)
			{
				return 1;
			}
			return (A[n-2] > A[n-1]) ? 0: IsSorted(n-1,A);
		}
		
		public static void Main()
		{
			int[] arr = new int[]{1,2,6,4,5};
			if(IsSorted(arr.Length,arr) == 1)
				Console.WriteLine("Array is sorted");
			else
				Console.WriteLine("Array is NOT sorted");
			Console.ReadKey();
		}
		
	}
}