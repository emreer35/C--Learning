// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// string[] ogrenciler = new string[] {
//     "ali",
//     "veli",
//     "ogrneciler",
//     "Asdasfasg",
//     "asdasda",
//     "asdsafasgasgd"
// };

// for (int i = 0; i < ogrenciler.Length; i++)
// {
//     System.Console.WriteLine(ogrenciler[i]);
// }

// foreach (var ogrenci in ogrenciler)
// {
//     System.Console.WriteLine('-' + ogrenci);
// }


using System;

namespace DiziOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            course.courseName = "C# Egitimi";
            course.instructorName = "Yunus EMre Er";
            course.view = 883;
            Course course1 = new Course();
            course1.courseName = "C# Egitimi";
            course1.instructorName = "Yunus EMre Er";
            course1.view = 883;
            Course course2 = new Course();
            course2.courseName = "C# Egitimi";
            course2.instructorName = "Yunus EMre Er";
            course2.view = 883;
            // System.Console.WriteLine(course.courseName);
            // System.Console.WriteLine(course.instructorName);

            Course[] courses = new Course[] {
                course, course1, course2
            };

            foreach (Course  item in courses)
            {
                System.Console.WriteLine(item.courseName + " " + item.instructorName + " " + item.view);
            }
        }
    }
    class Course
    {
        public string courseName { get; set; } = string.Empty;
        public string instructorName { get; set; } = string.Empty;
        public int view { get; set; }

    }

}