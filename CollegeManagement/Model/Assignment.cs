using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Model
{
    public class Assignment
    {
        public Assignment(string name, string description)
        {
            Name = name;
            Description = description;
        }

        [Key]
        public int AssingmentID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Course Course { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; }
    }
}
