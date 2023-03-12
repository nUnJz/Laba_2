using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Laba_2_2
{
    class Employee
    {
        public string Surname { get; set; }
        public int Experience { get; set; }

        public Employee (string surname, int experience)
        {
            Surname = surname;
            Experience = experience;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            List<Employee> employees = new List<Employee>();

            using (StreamReader reader = new StreamReader("Співробітники.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    employees.Add(new Employee(words[0], int.Parse(words[1])));
                }
            }

            var sortedEmployee = employees.OrderBy(e => e.Experience);

            Console.WriteLine("Відсортований перелік:");
            Console.WriteLine();

            foreach (var e in sortedEmployee)
            Console.WriteLine($"{e.Surname} {e.Experience}");

            Console.ReadLine();
        }
    }
}