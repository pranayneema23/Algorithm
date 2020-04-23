using System;
namespace Recursion
{
    class TowerOfHanoi
    {
        public static void MoveDisk(int n,string SourceTower,string DestinationTower,string IntermediateTower)
        {
            ///Base Condition
            if(n == 1)
            {
                 Console.WriteLine("Move disk 1 from " + SourceTower + " to tower " + DestinationTower);
                 return;
            }
            
            MoveDisk(n-1,SourceTower,IntermediateTower,DestinationTower);
            Console.WriteLine("Move disk "+ n + " from " + SourceTower + " to tower " + DestinationTower);
            MoveDisk(n-1,IntermediateTower,DestinationTower,SourceTower);
        }

        public static void Main()
        {

            int n;//Integer value
            string source,destination,auxiliary;//value can be first,second,third
            Console.WriteLine("Enter the number of disk");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Souce disk");
            source = Console.ReadLine();
            Console.WriteLine("Enter the Destination disk");
            destination = Console.ReadLine();
            Console.WriteLine("Enter the Auxiliary disk");
            auxiliary = Console.ReadLine();
            MoveDisk(n,source,destination,auxiliary);
        }
    }
}