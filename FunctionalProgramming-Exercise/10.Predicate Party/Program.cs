using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._TriFunCtion
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split().ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Party!")
                {
                    break;
                }
                Predicate<string> predicate = null;
                var commandSplitted = command.Split();
                if (commandSplitted[0]=="Remove")
                {

                }

            }
        }

        

        

    }
}
