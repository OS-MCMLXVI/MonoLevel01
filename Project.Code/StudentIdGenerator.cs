using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
      public sealed class StudentIdGenerator
      {
            private StudentIdGenerator() { }

            private static StudentIdGenerator instance = null;

            public static StudentIdGenerator InstanceSIG
            {
                  get
                  {
                        if (instance == null)
                              instance = new StudentIdGenerator();

                        return instance;
                  }
            }


            public string GetID()
            {
                  System.Guid guid = System.Guid.NewGuid();
                  return guid.ToString();
            }
      }
}
