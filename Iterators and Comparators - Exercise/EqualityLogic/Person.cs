using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EqualityLogic
{
    public class Person:IComparable<Person>
    {
        

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }


        public int CompareTo([AllowNull] Person other)
        {
            int comparison = this.Name.CompareTo(other.Name);
            if (comparison == 0)
            {
                comparison = this.Age.CompareTo(other.Age);
            }
            return comparison;
        }



        public override bool Equals(object obj)
        {
            if (obj != null && obj is Person other)
            {
                return this.Name == other.Name && this.Age == other.Age;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode();
        }
    }
}
