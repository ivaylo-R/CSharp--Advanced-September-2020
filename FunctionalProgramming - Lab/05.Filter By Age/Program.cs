using System;
using System.Linq;

namespace _05.Filter_By_Age
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = line[0];
                people[i] = new Person()
                {
                    Name = name,
                    Age = int.Parse(line[1])
                };

            }
            var condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person, bool> conditionDelegate = GetCondition(condition, age);
            Action<Person> formatDeleagte = GetPrinter(format);
            foreach (var person in people)
            {
                if (conditionDelegate(person))
                {
                    formatDeleagte(person);
                }
            }
        }

        private static Action<Person> GetPrinter(string format)
        {
            if (format == "name")
            {
                return p => { Console.WriteLine($"{p.Name}"); };
            }
            else if (format == "name age")
            {
                return p => { Console.WriteLine($"{p.Name} - {p.Age}"); };
            }
            else if (format == "age")
            {
                return p => { Console.WriteLine($"{p.Age}"); };
            }
            return null;
        }

        public static Func<Person, bool> GetCondition(string condition, int age)
        {
            if (condition == "younger")
            {
                return p => p.Age < age;
            }
            else
            {
                return p => p.Age >= age;
            }

        }


    }
}
