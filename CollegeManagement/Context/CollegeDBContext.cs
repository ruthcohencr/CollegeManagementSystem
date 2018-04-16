using CollegeManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Context
{
    public class CollegeDbContext : DbContext
    {
        public CollegeDbContext()
            :base("name=CollegeDbContext")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<StudentInCourse> StudentInCources { get; set; }
    }
}
