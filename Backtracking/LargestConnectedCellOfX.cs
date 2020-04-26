using System;

namespace Recursion.Backtracking
{
	class LargestConnectedCellOfX
	{
		public static int getval(int[,] A ,int i,int j,int L,int H)
		{
			if(i<0 || i>=L || j<0 || j>=H)
			{
				return 0;
			}
			else
			{
				return A[i,j];
			}
		}

		public static void findMaxBlock(int[,] A,int r,int c,int L,int H,int size,bool[,] cntarr,ref int maxsize)
		{
			if(r>=L ||c>=H)
				return;
			cntarr[r,c] = true;
			size++;
			if(size > maxsize)
				maxsize = size;
			//Search in 8 directions
			int[,] directions = new int[,]{{-1,0},{-1,-1},{0,-1},{1,-1},{1,0},{1,1},{0,1},{-1,1}};
			for(int i=0;i<8;i++)
			{
				int newi = r + directions[i,0];
				int newj = c + directions[i,1];
				int val = getval(A,newi,newj,L,H);
				if(val>0 && (cntarr[newi,newj]==false))
				{
					findMaxBlock(A,newi,newj,L,H,size,cntarr,ref maxsize);
				}
			}
			cntarr[r,c] = false;
		}

		public static int getMaxOnes(int[,] A,int rmax,int colmax)
		{
			int maxsize = 0;
			//int size = 0;
			bool[,] cntarr = new bool[rmax,colmax];
			for(int i=0;i<rmax;i++)
			{
				for(int j=0;j<colmax;j++)
				{
					if(A[i,j] == 1)
					{
						findMaxBlock(A,i,j,rmax,colmax,0,cntarr,ref maxsize);
					}
				}
			}
			return maxsize;
		}
		public static void Main()
		{
			Console.WriteLine("Enter the value of n for nxn array");
			int n = Convert.ToInt32(Console.ReadLine());
			int[,] A = new int[n,n];
			for(int i=0;i<n;i++)
			{
				for(int j=0;j<n;j++)
				{
					A[i,j] = Convert.ToInt32(Console.ReadLine());
				}
			}

			Console.WriteLine("Length of connected cell are : " + getMaxOnes(A,n,n));
		}
	}
}