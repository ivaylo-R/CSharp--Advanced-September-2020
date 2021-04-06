using System;
using System.Collections.Generic;
using System.Linq;
namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            
            {
                var line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var student = line[0];
                var grade = double.Parse(line[1]);
                if (!students.ContainsKey(student))
                {
                    students.Add(student, new List<double> { grade});
                }
                else
                {
                    students[student].Add(grade);
                }
                
            }

            foreach (var kvp in students)
            {
                Console.WriteLine($"{kvp.Key} -> {string.Join(" ",kvp.Value)} (avg: {kvp.Value.Average():F2})");
            }
        }
    }
}
