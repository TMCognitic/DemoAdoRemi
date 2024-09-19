using DemoOO.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Models.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> Get();
    }
}
