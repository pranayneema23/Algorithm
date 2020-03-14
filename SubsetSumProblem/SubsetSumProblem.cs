// A Dynamic Programming solution for subset sum problem 
using System; 
using System.Collections; 
using System.Collections.Generic; 
  
class GFG 
{ 
	static bool [,]subset; 
	static void display(ArrayList v) 
    { 
       foreach (var item in v)
			Console.Write(item + " ");
		Console.WriteLine();
    } 
	static void printSubsetsRec(int[] set,int i,int sum,ArrayList p )
	{
		// If we reached end and sum is non-zero. We print 
        // p[] only if arr[0] is equal to sun OR dp[0][sum] 
        // is true. 
        if (i == 0 && sum != 0 && subset[0,sum]) 
        { 
            p.Add(set[i]); 
            display(p); 
            p.Clear(); 
            return; 
        } 
		
		// If sum becomes 0 
        if (i == 0 && sum == 0) 
        { 
            display(p); 
            p.Clear(); 
            return; 
        }
		
		// If given sum can be achieved after ignoring 
        // current element. 
        if (subset[i-1,sum]) 
        { 
            // Create a new vector to store path 
            ArrayList b = new ArrayList(); 
            b.AddRange(p); 
            printSubsetsRec(set, i-1, sum, b); 
        } 
       
        // If given sum can be achieved after considering 
        // current element. 
        if (sum >= set[i] && subset[i-1,sum-set[i]]) 
        { 
            p.Add(set[i]); 
            printSubsetsRec(set, i-1, sum-set[i], p); 
        } 
		
		
	}
    // Returns true if there is a subset  
    // of set[] with sun equal to given sum 
    static bool isSubsetSum(int []set, int n, int sum) 
    { 
        // The value of subset[i][j] will be true if there  
        // is a subset of set[0..i] with sum equal to j
        subset = new bool[n,sum+1]; 
      
        // If sum is 0, then answer is true 
        for (int i = 0; i < n; i++) 
        subset[i,0] = true; 
      
        // If sum is not 0 and set is empty, then answer is false 
        if (set[0] <= sum)
			subset[0,set[0]] = true;
      
        // Fill the subset table in bottom up manner 
        for (int i = 1; i < n; i++) 
        { 
            for (int j = 1; j < sum + 1; j++) 
            { 
                subset[i, j] = subset[i-1,j]; 
                if (j >= set[i]) 
                subset[i, j] = subset[i, j] ||  
                               subset[i - 1, j - set[i]]; 
                                              
            } 
        } 
      
		for (int i = 0; i <n; i++) 
		 { 
		   for (int j = 0; j <= sum; j++) 
			  Console.Write(subset[i,j] + " "); 
		   Console.WriteLine(""); 
		 }
		 
		// Now recursively traverse dp[][] to find all 
        // paths from dp[n-1][sum] 
        ArrayList p = new ArrayList(); 
        printSubsetsRec(set, n-1, sum, p); 
        return subset[n-1,sum]; 
    } 
      
    // Driver program  
    public static void Main () 
    { 
		Console.WriteLine("Enter no of elements : ");
		int n = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter space seprated element : ");
		string inputString = Console.ReadLine();
		string[] inputStringArr = inputString.Split(' ');
		int[] set = Array.ConvertAll(inputStringArr, int.Parse);
		Console.WriteLine("Enter sum value");
		int sum = Convert.ToInt32(Console.ReadLine());

        if (isSubsetSum(set, n, sum) == true) 
            Console.WriteLine("Found a subset with given sum"); 
        else
            Console.WriteLine("No subset with given sum"); 
    } 
} 