using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeManagement.Model
{
    public abstract class Person
    {
        public Person()
        {

        }

        public Person(string name, Address address, string phone, DateTime dateStart)
        {
            Name = name;
            Address = address;
            Phone = phone;
            DateStart = dateStart;
        }

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public DateTime DateStart { get; set; }
    }
}
