using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code.Models
{
      public class Student : Person
      {
            private float gpa;

            public Student(string fName, string lName, float gpa) : base(fName, lName)
            {
                  this.gpa = gpa;
            }

            public float Gpa
            {
                  get { return this.gpa; }
            }
      }
}
