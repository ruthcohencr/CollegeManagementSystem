using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeManagement.Model
{
    public class Lesson
    {
        public Lesson(string name,int number,string description,string link)
        {
            Name = name;
            Number = number;
            Description = description;
            LinkToDescription = link;
        }

        [Key]
        public int LessonID { get; set; }

        [Required]
        public string Name { get; set; }
     
        public int Number { get; set; }

       // [Required]
       // [StringLength(10)]
        public string Description { get; set; }
        public string LinkToDescription { get; set; }

        public virtual Course Course { get; set; }
        [ForeignKey("Course")]
        public int? CourseID { get; set; }
    }
}

// public virtual UserDB Owner { get; set; }

//[ForeignKey("Owner")]
//public int? OwnerID { get; set; }