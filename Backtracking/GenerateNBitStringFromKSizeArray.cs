using System;
namespace Recursion.Backtracking
{
	class GenerateNBitStringFromKSizeArray
	{
		public static int[] A;
		public static void K_String(int N,int K)
		{
			if(N < 1)
			{
				foreach(var val in A)
				{
					Console.Write(val);
				}
				Console.WriteLine();
			}
			else
			{
				for(int i=0;i<K;i++)
				{
					A[N-1] = i;
					K_String(N-1,K);
				}
			}
		}
		
		public static void Main()
		{
			Console.WriteLine("Enter the value of N : ");
			int N = Convert.ToInt32(Console.ReadLine());
			A = new int[N];
			Console.WriteLine("Enter the value of K : ");
			int K = Convert.ToInt32(Console.ReadLine());
			K_String(N,K);
		}
	}
}