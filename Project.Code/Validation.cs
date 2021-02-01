using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
      public static class Validation
      {
            public static bool CheckOperation(string inputValue)
            {
                  if (Operations.operations.Contains(inputValue))
                        return true;

                  return false;
            }

            public static bool CheckUserInput(string input)
            {
                  if (String.IsNullOrEmpty(input))
                  {
                        Console.WriteLine("You need to insert value...");
                        return true;
                  }

                  return false;
            }
      }
}
