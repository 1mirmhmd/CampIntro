﻿namespace _03_ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ali";
            int age = 34;
            Course course = new Course() { CourseName = "C#", Instructor = name, ViewNumber = 712 };
            Course course1 = new Course();
            course1.CourseName = "Kotlin";
            course1.Instructor = "Aziz";
            course1.ViewNumber = 345;

            Course[] courses = new Course[] { course1, course };
            foreach (var course_ in courses)
            {
                Console.WriteLine(course_.CourseName);
            }

        }
        public class Course
        {
            public string CourseName { get; set; }
            public string Instructor { get; set; }
            public int ViewNumber { get; set; }

        }
    }
}
