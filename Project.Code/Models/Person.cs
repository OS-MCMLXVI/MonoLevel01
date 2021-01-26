using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code.Models
{
      public abstract class Person
      {
            private string _firstName;
            private string _lastName;
            private string _id;

            public Person(string fName, string lName)
            {
                  this._firstName = fName;
                  this._lastName = lName;
                  this._id = StudentIdGenerator.InstanceSIG.GetID();
            }

            public string FirstName
            {
                  get { return this._firstName; }
            }

            public string LastName
            {
                  get { return this._lastName; }
            }

            public string Id
            {
                  get { return this._id; }
            }
      }
}
