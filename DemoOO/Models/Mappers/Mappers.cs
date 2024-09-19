using DemoOO.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Models.Mappers
{
    internal static class Mappers
    {
        internal static Student ToStudent(this IDataRecord dataRecord)
        {
            return new Student((int)dataRecord["Student_Id"], (string)dataRecord["last_name"], (string)dataRecord["first_name"]);
        }
    }
}
