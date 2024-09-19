using DemoOO.Models.Entities;
using DemoOO.Models.Mappers;
using DemoOO.Models.Repositories;
using DemoOO.Tools;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Models.Services
{
    public class StudentService : IStudentRepository
    {
        public IEnumerable<Student> Get()
        {
            using(SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbSlide;Integrated Security=True;Connect Timeout=60;Encrypt=True;Trust Server Certificate=True;"))
            {
                connection.Open();
                return connection.ExecuteReader("SELECT student_id, last_name, first_name FROM student;", dr => dr.ToStudent()).ToList();                 
            }
        }
    }
}
