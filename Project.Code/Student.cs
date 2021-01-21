﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
      public class Student : Person
      {
            public static List<Student> studentsList = new List<Student>();
            private float _gpa;

            public Student(string fName, string lName, float gpa) : base(fName, lName)
            {
                  this._gpa = gpa;
            }


            public float Gpa
            {
                  get { return this._gpa; }
            }
      }
}
