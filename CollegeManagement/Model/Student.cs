using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Model
{
    public class Student: Person
    {
        //This constructor is needed for the proxy
        public Student()
        { }

        public Student(string name, Address address, string phone, DateTime dateStart)
            :base(name, address,phone,dateStart)
        { }

        public Student(Student s)
            :base(s.Name, s.Address, s.Phone, s.DateStart)
        {
            
        }

        public virtual ICollection<StudentInCourse> StudentInCourses { get; set; }

    }
}
