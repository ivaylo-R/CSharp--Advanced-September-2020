using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                else if (line == "PARTY")
                {
                    bool isEndOfTheParty = RemoveGuestsCameInTheList(set, line);
                    if (isEndOfTheParty)
                    {
                        break;
                    }
                }

                set.Add(line);
            }

            Console.WriteLine(set.Count);
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }



        private static bool RemoveGuestsCameInTheList(HashSet<string> set, string line)
        {
            while (set.Count > 0)
            {
                set.Remove(line);
                line = Console.ReadLine();
                if (line == "END")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
