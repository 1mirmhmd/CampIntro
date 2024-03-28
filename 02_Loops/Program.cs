namespace _02_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string course1 = "Software developer training camp";
            string course2 = "Base course for beginner";
            string course3 = "Python";
            string course4 = "C++";

            Console.WriteLine(course1);
            Console.WriteLine(course2);
            Console.WriteLine(course3);
            Console.WriteLine(course4);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // Arrays
            string[] courses = new string[] { "Software developer training camp", "Base course for beginner", "java camp", "Python" };
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
            // foreach içerisindeki course'a alias denir
            foreach (var course in courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}
