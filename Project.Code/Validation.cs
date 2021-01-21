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
                  for (int i = 0; i < Operations.operations.Length; i++)
                        if (inputValue == Operations.operations[i])
                              return true;

                  return false;
            }

            public static bool CheckEmptyInput(string inputValue)
            {
                  if (String.IsNullOrEmpty(inputValue))
                        return true;

                  return false;
            }

            public static bool CheckFirstChar(string inputValue)
            {
                  if (Char.IsDigit(inputValue, 0))
                        return true;

                  return false;
            }

            public static bool CheckNumber(string inputValue)
            {
                  float number;

                  if (float.TryParse(inputValue, out number))
                        if (number >= 1.00 && number <= 5.00)
                              return true;

                  return false;
            }
      }
}
