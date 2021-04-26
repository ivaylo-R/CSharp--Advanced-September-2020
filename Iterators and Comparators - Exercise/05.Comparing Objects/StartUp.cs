using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> persons = new List<Person>();
            int countOfEquals = 0;
            int countOfNotEquals = 0;

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "END")
                {
                    break;
                }
                var name = input[0];
                var age = int.Parse(input[1]);
                var town = input[2];
                Person person = new Person(name, age, town);
                persons.Add(person);
            }

            int totalNumberOfPeople = persons.Count;
            int indexOfPersonToCompare = int.Parse(Console.ReadLine());
            indexOfPersonToCompare--;
            Person personToCompare = persons[indexOfPersonToCompare];
            foreach (var person in persons)
            {
                if (personToCompare.CompareTo(person) == 0)
                {
                    countOfEquals++;
                }
                else
                {
                    countOfNotEquals++;
                }
            }

            if (countOfEquals<=1)
            {
                Console.WriteLine("No matches");
                return;
            }

            Console.Write($"{countOfEquals} {countOfNotEquals} {totalNumberOfPeople}");
            Console.WriteLine();
        }
    }
}
