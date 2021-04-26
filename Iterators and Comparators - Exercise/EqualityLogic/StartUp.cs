using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<Person> hashSet = new HashSet<Person>();
            SortedSet<Person> sortedSet = new SortedSet<Person>();

            for (int i = 0; i < n; i++)
            {
                var tokens =Console.ReadLine().Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                Person person = new Person(name, age);
                
                hashSet.Add(person);
                sortedSet.Add(person);
            }

            Console.WriteLine(hashSet.Count);
            
            Console.WriteLine(sortedSet.Count);


        }
    }
}
