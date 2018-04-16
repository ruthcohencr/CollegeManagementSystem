using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Model
{
    public class LecturerInCourses
    {
        [Key, Column(Order = 0)]
        public int LecturerID { get; set; }

        [Key, Column(Order = 1)]
        public int CourseID { get; set; }

        public virtual Lecturer Lecturer { get; set; }
        public virtual Course Course { get; set; }

      //  [Required]
        public int StudentAmount { get; set; }
    }
}
