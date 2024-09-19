using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Models.Entities
{
    public class Student
    {
        public Student(int id, string lastName, string firstName)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }


    }
}
