using CollegeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var college = new CollegeRepository();
            // print count of student
            Console.WriteLine(college.GetStudentsAmount());

            // print all students names
            var students = college.GetStudents();
            foreach (var s in students)
            {
                Console.Write(s.Name+", ");
            }

            // print all student learning in cousre "C# basic course"
            //var studentsInCourse = college.GetStudentsNames("C# basic course");
            //studentsInCourse.ForEach(s => Console.Write(s.Name + ","));

            Console.WriteLine();
            List<Student> studentsInCourse = college.GetStudents("C# basic course");
            studentsInCourse.ForEach(s => Console.Write((s as Student).Name + ","));


            Console.ReadKey();
        }
    }
}
