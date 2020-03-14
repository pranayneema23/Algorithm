using System;
using System.Collections.Generic;
namespace Algorithm
{
	class SubsetSumRecursive
	{
		public static int CountSubset(int[] arr,int total, int i,ref Dictionary<string,int> memo )
		{
			string key = total +":"+i;
			int result;
			if(memo.TryGetValue(key,out result))
				return result;
			if(total == 0)
				return  1;
			else if(total < 0)
				return 0;
			else if(i < 0)
				return 0;
			else if(total < arr[i])
				result = CountSubset(arr,total,i-1,ref memo);
			else
				result = CountSubset(arr,total - arr[i],i-1,ref memo) + CountSubset(arr,total,i-1,ref memo);
			memo.Add(key,result);
			return result;
		}
		public static void Main()
		{
			Console.WriteLine("Enter no of elements : ");
			int len = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter space seprated element : ");
			string inputString = Console.ReadLine();
			string[] inputStringArr = inputString.Split(' ');
			int[] elements = Array.ConvertAll(inputStringArr, int.Parse);
			Console.WriteLine("Enter sum value");
			int sum = Convert.ToInt32(Console.ReadLine());
			Dictionary<string,int> memo = new Dictionary<string,int>();
			// Console.WriteLine("Total element : "+ len);
			// Console.Write("Elements : ");		
			// foreach(int val in elements)
				// Console.Write(val + " ");
			// Console.WriteLine();
			// Console.WriteLine("Value of sum is " + sum);
			
			Console.WriteLine("No. of possible subset are :- " + CountSubset(elements,sum,elements.Length -1,ref memo));
		}
	}
}