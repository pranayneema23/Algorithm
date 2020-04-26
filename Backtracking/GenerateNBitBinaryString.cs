using System;

namespace Recursion.Backtracking
{
	class GenerateNBitBinaryString
	{
		public static int[] A;
		//Recurence Relation = T(n) = 2T(n-1) + 
		public static void GenerateBinaryString(int N)
		{
			if(N < 1)
			{
				foreach(var val in A)
					Console.Write(val);
				Console.WriteLine();
			}
			else
			{
				A[N-1] = 0;
				GenerateBinaryString(N-1);
				A[N-1] = 1;
				GenerateBinaryString(N-1);
			}
		}
		
		public static void Main()
		{
			Console.WriteLine("Enter the value of N : ");
			int N = Convert.ToInt32(Console.ReadLine());
			A = new int[N];
			GenerateBinaryString(N);
		}
	}
}