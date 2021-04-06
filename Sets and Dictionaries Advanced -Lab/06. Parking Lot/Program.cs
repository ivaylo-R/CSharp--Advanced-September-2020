using System;
using System.Collections.Generic;
namespace _06._Parking_Lot
{
    class Program
    {
        static void Main()
        {
            HashSet<string> set = new HashSet<string>();
            while (true)
            {
                var tokens = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];
                if (command == "END")
                {
                    break;
                }

                var plateNum = tokens[1];
                if (command == "IN")
                {
                    set.Add(plateNum);
                }
                else if(command == "OUT")
                {
                    set.Remove(plateNum);
                }
            }

            if (set.Count > 0)
            {
                foreach (var plateNum in set)
                {
                    Console.WriteLine(plateNum);
                }
            }
            else Console.WriteLine("Parking Lot is Empty");
            
        }
    }
}
