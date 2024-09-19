using System.Data.Common;
using System.Data;
using DemoOO.Tools;
using DemoOO.Models.Entities;
using DemoOO.Models.Repositories;
using DemoOO.Models.Services;

namespace DemoOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudentRepository studentRepository = new StudentService();

            foreach(Student student in studentRepository.Get())
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
    }
}