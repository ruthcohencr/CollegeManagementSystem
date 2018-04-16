using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Model
{
    public class Course
    {
        public Course(string name)
        {
            Name = name;
            Lessons = new List<Lesson>();
            Assignments = new List<Assignment>();
            
        }

        [Key]
        public int CourseID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Lesson> Lessons { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }

        public virtual ICollection<StudentInCourse> StudentInCourse { get; set; }

        public virtual ICollection<LecturerInCourses> LecturerInCourses { get; set; }

    }
}
