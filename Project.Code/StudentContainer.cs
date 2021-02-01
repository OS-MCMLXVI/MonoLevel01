using Project.Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
      public static class StudentContainer
      {
            public static readonly List<Student> studentsList = new List<Student>();

            public static void AddStudent(Student student)
            {
                  studentsList.Add(student);
            }
      }
}
