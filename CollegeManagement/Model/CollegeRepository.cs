using CollegeManagement.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Model
{
    public class CollegeRepository
    {
        //count student
        public int GetStudentsAmount()
        {
            var num = 0;
            using (var context = new CollegeDbContext())
            {
                num = context.Students.Count<Student>();
            }

            return num;
        }
        // Return student list
        public List<Student> GetStudents()
        {
            List<Student> studentList;
            using (var context = new CollegeDbContext())
            {
                studentList = context.Students.ToList();
            }
            return studentList;
        }

        public List<Student> GetStudentsNames(string courseName)
        {
            List<Student> studentList = new List<Student>();
            using (var context = new CollegeDbContext())
            {
                var query =
                    from course in context.Courses
                    join studentCourse in context.StudentInCources on course.CourseID equals studentCourse.CourseID
                    where course.Name == courseName
                    join student in context.Students on studentCourse.StudentID equals student.ID
                    select new Student
                    {
                        ID = student.ID,
                        Name = student.Name,
                        Address = student.Address,
                        DateStart = student.DateStart,
                        Phone = student.Phone,
                        StudentInCourses = student.StudentInCourses
                    };
                query.ToList();

            }
            return studentList;
        }

        public List<Student> GetStudents(string courseName)
        {
            List<Student> studentList;
            
            using (var context = new CollegeDbContext())
            {
                 IQueryable<Student> query =
                  from course in context.Courses
                  join studentCourse in context.StudentInCources
                  on course.CourseID equals studentCourse.CourseID
                  where course.Name == courseName
                  join student in context.Students
                  on studentCourse.StudentID equals student.ID
                  select student;

                studentList = query.ToList();

            //    studentList.ForEach(s => Console.WriteLine((s as Student).Name));
            }
            return studentList;
        }
    } 
}
