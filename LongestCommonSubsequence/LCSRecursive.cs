using System;

namespace LCS
{
	class LCSLength
	{
		public static int LCSLengthRecursive(string X,string Y,int n,int m,ref int[,] L)
		{
			int result;
			if(n==0 || m==0 )
				return 0;
			else if(L[n,m] != 0)
				return L[n,m];
			else if(X[n-1] == Y[m-1])
				result =  1 +  LCSLengthRecursive(X,Y,n-1,m-1,ref L);
			else
				result = Math.Max(LCSLengthRecursive(X,Y,n-1,m,ref L),LCSLengthRecursive(X,Y,n,m-1,ref L));
			L[n,m] = result;
			return result;
		}
		public static void  PrintLCS(string X,string Y,int[,] L)
		{
			int index = L[X.Length,Y.Length];
			int temp = index;
			char[] lcs = new char[index+1];
			lcs[index] = '\0';
			int k=X.Length,l=Y.Length;
			while(k>0 && l>0)
			{
				if (X[k-1] == Y[l-1]) 
				{ 
					// Put current character in result 
					lcs[index-1] = X[k-1];  
					  
					// reduce values of i, j and index 
					k--;  
					l--;  
					index--;      
				} 
				else if (L[k-1, l] > L[k, l-1]) 
					k--; 
				else
					l--; 
			}
			
			Console.Write("LCS of " + X + " and " + Y + " is "); 
			for(int q = 0; q <= temp; q++) 
				Console.Write(lcs[q]); 
			//return lcs;
		}
		public static void Main()
		{
			string X,Y;
			Console.WriteLine("Enter 1st string");
			X = Console.ReadLine();
			Console.WriteLine("Enter 2nd string");
			Y = Console.ReadLine();
			int[,] L =new int [X.Length+1,Y.Length+1];
			//For length zero
			for(int i=0;i<=X.Length;i++)
			{
				for(int j=0;j<=Y.Length;j++)
				{
					if (i == 0 || j == 0) 
						L[i,j] = 0;
				}
					
			}
			Console.WriteLine("Length of Longest common substring is : " + LCSLengthRecursive(X,Y,X.Length,Y.Length,ref L));
			for(int i=0;i<X.Length;i++)
			{
				for(int j=0;j<Y.Length;j++)
					Console.Write(L[i,j] + " ");
				Console.WriteLine();
			}
			PrintLCS(X,Y,L);
			
		}
	}
}