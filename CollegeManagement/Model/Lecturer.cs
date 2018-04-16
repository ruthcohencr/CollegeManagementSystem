using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Model
{
    public class Lecturer : Person
    {
        public Lecturer(string name, Address address, string phone, DateTime dateStart)
            :base(name, address, phone, dateStart)
        {

        }

        public virtual ICollection<LecturerInCourses> LecturerInCourses { get; set; }
    }
}
