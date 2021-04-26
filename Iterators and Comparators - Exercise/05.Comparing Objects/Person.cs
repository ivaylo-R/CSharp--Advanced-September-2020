using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public string Name { get; set; }
            
        private int Age { get; set; }
        private string Town { get; set; }

        public int CompareTo(Person other)
        {
            var comparison = this.Name.CompareTo(other.Name);
            if (comparison == 0)
            {
                comparison = this.Age.CompareTo(other.Age);

                if (comparison == 0)
                {
                    comparison = this.Town.CompareTo(other.Town);
                }
            }
            return comparison;

        }
    }
}
