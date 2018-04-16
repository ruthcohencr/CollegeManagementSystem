using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Model
{
    public class StudentInCourse
    {
        public StudentInCourse(int studentID, int coursesID, DateTime startDate,DateTime endDate,int testGrade)
        {
            StudentID = studentID;
            CourseID = coursesID;
            StartDate = startDate;
            EndDate = endDate;
            TestGrade = testGrade;
        }

        [Key, Column(Order = 0)]
        public int StudentID { get; set; }

        [Key, Column(Order = 1)]
        public int CourseID { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? TestGrade { get; set; }
    }
}
