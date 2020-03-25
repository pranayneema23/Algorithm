using System;

namespace Find_Kth_duplicate
{
    class Program
    {
        public static int MAX_CHAR = 256;

        static int kthNonRepeating(String str,int k)
        {
            int n = str.Length;

            // count[x] is going to store count of 
            // character 'x' in str. If x is not 
            // present, then it is going to store 0. 
            int []count = new int[MAX_CHAR];

            // index[x] is going to store index of 
            // character 'x' in str. If x is not 
            // present or x is repeating, then it 
            // is going to store a value (for  
            // example, length of string) that 
            // cannot be a valid index in str[] 
            int []index = new int[MAX_CHAR]; 

            // Initialize counts of all characters 
            // and indexes of non-repeating  
            // characters. 
            for (int i = 0; i < MAX_CHAR; i++) 
            { 
                count[i] = 0; 
                
                // A value more than any index 
                // in str[] 
                index[i] = n;  
            }

            // Traverse the input string 
            for (int i = 0; i < n; i++) 
            { 
                
                // Find current character and  
                // increment its count 
                char x = str[i]; 
                ++count[x]; 
    
                // If this is first occurrence, 
                // then set value in index as 
                // index of it. 
                if (count[x] == 1) 
                    index[x] = i; 
    
                // If character repeats, then  
                // remove it from index[] 
                if (count[x] == 2) 
                    index[x] = n; 
            }

            // Sort index[] in increasing order.  
            // This step takes O(1) time as size 
            // of index is 256 only 
            Array.Sort(index); 
    
            // After sorting, if index[k-1] is 
            // value, then return it, else  
            // return -1. 
            return (index[k-1] != n) ? index[k-1] : -1;  
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            String str = Console.ReadLine();

            Console.WriteLine("Enter the value of K");
            int k = Int32.Parse(Console.ReadLine());

            int res = kthNonRepeating(str,k);

            Console.Write(res == -1 ? "There are less" + " than k non-repeating characters" : "k'th non-repeating character is "
                                                 + str[res]);
        }
    }
}
