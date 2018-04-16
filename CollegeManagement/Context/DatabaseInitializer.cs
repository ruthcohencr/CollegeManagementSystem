using CollegeManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Context
{
    class DatabaseInitializer : DropCreateDatabaseIfModelChanges<CollegeDbContext>
    {
        protected override void Seed(CollegeDbContext context)
        {
            Student student1 = new Student("Ruth", new Address("Ramat Hasharon", "Bet Govrin", 31, 6), "0503233453", DateTime.Now.AddDays(-5));
            Student student2 = new Student("Gila", new Address("Ra'anana", "Stars", 1, 2), "0503996699", DateTime.Now.AddDays(-25));
            Student student3 = new Student("Boris", new Address("Hertselia", "Moshe-sharet", 5, 12), "0501111111", DateTime.Now.AddDays(-45));
            Student student4 = new Student("Slava", new Address("Ra'anana", "Sokolov", 27, 2), "05022116699", DateTime.Now.AddDays(-225));

            context.Students.Add(student1);
            context.Students.Add(student2);
            context.Students.Add(student3);
            context.Students.Add(student4);


            Assignment assignment1 = new Assignment("assignmant1", "Write 10 starts to console");
            Assignment assignment12 = new Assignment("assignmant2", "Learning for loop");
            Assignment assignment13 = new Assignment("assignmant3", "C# vs Java");
            Assignment assignment2 = new Assignment("assignmant1", "Hello world application");
            Assignment assignment21 = new Assignment("assignmant2", "javaScript vs typeScript");

            context.Assignments.Add(assignment1);
            context.Assignments.Add(assignment12);
            context.Assignments.Add(assignment13);
            context.Assignments.Add(assignment2);
            context.Assignments.Add(assignment21);

            Lesson lesson1 = new Lesson("Introduction", 1, "Introduction to C#", "www.github\ruthcohen\\1");
            Lesson lesson2 = new Lesson("Dot Net framework", 1, "Building a hello world app", "www.github\ruthcohen\\2");
            Lesson lesson3 = new Lesson("Array", 1, "C# Array kinds", "www.github\ruthcohen\\3");
            Lesson lesson4 = new Lesson("Loops", 1, "For & While", "www.github\ruthcohen\\4");

            Lesson lesson5 = new Lesson("Introduction", 1, "Introduction to javaScript", "www.github\ruthcohen\\javaScript\\1");
            Lesson lesson6 = new Lesson("Dot Net framework", 1, "Building a hello world app", "www.github\ruthcohen\\javaScript\\2");
            Lesson lesson7 = new Lesson("Array", 1, "JavaScript Array kinds", "www.github\ruthcohen\\javaScript\\3");
            Lesson lesson8 = new Lesson("Loops", 1, "For & While", "www.github\ruthcohen\\javaScript\\4");

            context.Lessons.Add(lesson1);
            context.Lessons.Add(lesson2);
            context.Lessons.Add(lesson3);
            context.Lessons.Add(lesson4);
            context.Lessons.Add(lesson5);
            context.Lessons.Add(lesson6);
            context.Lessons.Add(lesson7);
            context.Lessons.Add(lesson8);

            Course course1 = new Course("C# basic course");
            Course course2 = new Course("JavaScript basic course");

            course1.Lessons.Add(lesson1);
            course1.Lessons.Add(lesson2);
            course1.Lessons.Add(lesson3);
            course1.Lessons.Add(lesson4);
            course2.Lessons.Add(lesson5);
            course2.Lessons.Add(lesson6);
            course2.Lessons.Add(lesson7);
            course2.Lessons.Add(lesson8);


            course1.Assignments.Add(assignment1);
            course1.Assignments.Add(assignment12);
            course1.Assignments.Add(assignment13);

            course2.Assignments.Add(assignment2);
            course2.Assignments.Add(assignment21);

            context.Courses.Add(course1);
            context.Courses.Add(course2);
            
            Lecturer lecturer1 = new Lecturer("Amir Adler", new Address("Petach Tikva", "Rishonim", 5, 9), "0504234556", DateTime.Now.AddDays(-100));
            Lecturer lecturer2 = new Lecturer("Aviv Berko", new Address("Ramat Gan", "Hamakabim", 1, 92), "0504111116", DateTime.Now.AddDays(-120));

            context.Lecturers.Add(lecturer1);
            context.Lecturers.Add(lecturer2);
            //must make save changes so db know all keys befure working with StudentInCourse
            context.SaveChanges();

            StudentInCourse sc = new StudentInCourse(student1.ID,course1.CourseID,DateTime.Now,DateTime.Now.AddDays(20),100);
            StudentInCourse sc2 = new StudentInCourse(student2.ID, course2.CourseID, DateTime.Now, DateTime.Now.AddDays(40), 98);
            StudentInCourse sc3 = new StudentInCourse(student3.ID, course1.CourseID, DateTime.Now, DateTime.Now.AddDays(20), 100);
            StudentInCourse sc4 = new StudentInCourse(student4.ID, course1.CourseID, DateTime.Now, DateTime.Now.AddDays(40), 98);

            context.StudentInCources.Add(sc);
            context.StudentInCources.Add(sc2);
            context.StudentInCources.Add(sc3);
            context.StudentInCources.Add(sc4);


            context.SaveChanges();
           // base.Seed(context);
        }
    }
}
