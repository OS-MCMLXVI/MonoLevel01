using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code.Models
{
      public abstract class Person
      {
            private string firstName;
            private string lastName;
            private string id;

            public Person(string fName, string lName)
            {
                  this.firstName = fName;
                  this.lastName = lName;
                  this.id = StudentIdGenerator.InstanceSIG.GetID();
            }

            public string FirstName
            {
                  get { return this.firstName; }
            }

            public string LastName
            {
                  get { return this.lastName; }
            }

            public string Id
            {
                  get { return this.id; }
            }
      }
}
