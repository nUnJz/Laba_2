using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Bot
{
    class Student
    {
        public string Surname { get; set; }
        public int Mark { get; set; }

        public Student(string surname, int mark)
        {
            Surname = surname;
            Mark = mark;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            List<Student> students = new List<Student>();

            using (StreamReader reader = new StreamReader("Студенти.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    students.Add(new Student(words[0], int.Parse(words[1])));
                }
            }

            List<Student> filteredStudents = students.FindAll(s => s.Mark >= 20);
            //students.Sort((x, y) => x.Mark.CompareTo(y.Mark));
            Console.WriteLine("Відфільтрований перелік:");
            Console.WriteLine();
            foreach (Student student in filteredStudents)
            {
                Console.WriteLine(student.Surname + " " + student.Mark);
            }
            //Console.WriteLine(String.Join(Environment.NewLine, students)); 

            Console.ReadLine();
        }
    }
}