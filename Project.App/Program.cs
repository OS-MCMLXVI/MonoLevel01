using Project.Code;
using Project.Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.App
{
      public class Program
      {
            static void Main(string[] args)
            {
                  ConsoleKeyInfo keyPressed;
                  string operationInput;


                  do
                  {
                        Console.Clear();
                        Console.WriteLine();
                        Console.Write("Operation options are =>    ");

                        foreach (string o in Operations.operations)
                              Console.Write(o + ",  ");

                        Console.WriteLine();
                        Console.Write("Operation......:  ");
                        operationInput = Console.ReadLine().Trim().ToUpper();

                        if (!Operations.operations.Contains(operationInput))
                        {
                              Console.WriteLine("Operation non-existing...  Press [ESC] for exit or any other key for continue...");
                              keyPressed = Console.ReadKey();

                              if (keyPressed.Key == ConsoleKey.Escape)
                                    Environment.Exit(0);
                        }

                        if (operationInput == "ENLIST")
                              Enlist();

                  } while (operationInput != "DISPLAY");

                  Display();
            }


            private static void Display()
            {
                  Console.Clear();
                  Console.WriteLine();

                  var sortList = StudentContainer.studentsList.OrderBy(x => x.LastName);
                  int rbr = 0;

                  foreach (var s in sortList)
                  {
                        rbr++;
                        Console.WriteLine(String.Format("{0,3}", rbr) + ".  ID: " + s.Id + ",   " + s.LastName + ", " + s.FirstName + ",  GPA:  " + s.Gpa.ToString("0.00"));
                  }

                  Console.WriteLine();
                  Console.WriteLine(">>>>>  Press any key...");
                  Console.ReadKey();
            }


            private static void Enlist()
            {
                  bool wrongInput = false;
                  string firstNameInput;
                  string lastNameInput;
                  string gpaInput;
                  float gpa;


                  Console.WriteLine();
                  Console.WriteLine("Student:");

                  firstNameInput = GetUserInput("First name............................:  ");
                  lastNameInput = GetUserInput("Last name.............................:  ");

                  do
                  {
                        if (wrongInput)
                        {
                              Console.WriteLine("Input number from 1,00 - 5,00 ...");
                              wrongInput = true;
                        }

                        gpaInput = GetUserInput("GPA...................................:  ");
                  } while (!(float.TryParse(gpaInput, out gpa) && gpa >= 1.00 && gpa <= 5.00));


                  // add student...
                  StudentContainer.AddStudent(new Student(firstNameInput, lastNameInput, float.Parse(gpaInput)));
            }

            static string GetUserInput(string displayText)
            {
                  string value;

                  do
                  {
                        Console.Write(displayText);
                        value = Console.ReadLine().Trim();
                  } while (Validation.CheckUserInput(value));

                  return value;
            }
      }
}
