using System;
using System.Collections.Generic;
using System.Linq;

namespace Task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var classes = new[]
            {
                new Classroom { Students = { "Evgeniy", "Sergey", "Andrew" }, },
                new Classroom { Students = { "Anna", "Viktor", "Vladimir" }, },
                new Classroom { Students = { "Bulat", "Alex", "Galina" }, }
            };

            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        private static string[] GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(a => a.Students).ToArray(); // Всего одна строка:) LINQ - это COOL!
        }

        public class Classroom
        {
            private List<string> students = new List<string>();

            public List<string> Students { get => students; set => students = value; }
        }
    }
}
