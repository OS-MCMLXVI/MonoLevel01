using Project.Code;
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
                  string operation;


                  while (true)
                  {
                        Console.Clear();
                        Console.WriteLine();
                        Console.Write("Operation options are =>    ");

                        for (int i = 0; i < Operations.operations.Length; i++)
                              Console.Write(Operations.operations[i] + ",  ");

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Operation......:  ");
                        operation = Console.ReadLine().Trim().ToUpper();

                        if (!Validation.CheckOperation(operation))
                        {
                              Console.WriteLine("Operation non-existing, please use appropriate operation. Press [ESC] for exit or any other key for continue...");
                              keyPressed = Console.ReadKey();

                              if (keyPressed.Key == ConsoleKey.Escape)
                                    break;

                              continue;
                        }

                        if (operation == "DISPLAY")
                        {
                              Display();
                              break;
                        }

                        Enlist();
                  }
            }


            private static void Display()
            {
                  Console.Clear();
                  Console.WriteLine();

                  var sortList = Student.studentsList.OrderBy(x => x.LastName);
                  int _rbr = 0;

                  foreach (var s in sortList)
                  {
                        _rbr++;
                        Console.WriteLine(String.Format("{0,3}", _rbr) + ".  ID: " + s.Id + ",   " + s.LastName + ", " + s.FirstName + ",  GPA:  " + s.Gpa.ToString("0.00"));
                  }

                  Console.WriteLine();
                  Console.WriteLine("> > > > >   Press any key...");
                  Console.ReadKey();
            }


            private static void Enlist()
            {
                  string _firstName;
                  string _lastName;
                  string _gpa;


                  Console.WriteLine();
                  Console.WriteLine("Student:");


                  while (true)
                  {
                        Console.Write("First name............................:  ");
                        _firstName = Console.ReadLine().Trim();

                        if (Validation.CheckEmptyInput(_firstName))
                        {
                              Console.WriteLine("You need to insert value.        Press any key...");
                              Console.ReadKey();
                              Console.WriteLine();
                              continue;
                        }

                        if (Validation.CheckFirstChar(_firstName))
                        {
                              Console.WriteLine("First character must bee letter.        Press any key...");
                              Console.ReadKey();
                              Console.WriteLine();
                              continue;
                        }

                        break;
                  }


                  while (true)
                  {
                        Console.Write("Last name.............................:  ");
                        _lastName = Console.ReadLine().Trim();

                        if (Validation.CheckEmptyInput(_lastName))
                        {
                              Console.WriteLine("You need to insert value.        Press any key...");
                              Console.ReadKey();
                              Console.WriteLine();
                              continue;
                        }

                        if (Validation.CheckFirstChar(_lastName))
                        {
                              Console.WriteLine("First character must bee letter.        Press any key...");
                              Console.ReadKey();
                              Console.WriteLine();
                              continue;
                        }

                        break;
                  }


                  while (true)
                  {
                        Console.Write("GPA...................................:  ");
                        _gpa = Console.ReadLine().Trim();

                        if (!Validation.CheckNumber(_gpa))
                        {
                              Console.WriteLine("You need to insert numerical value.        Press any key...");
                              Console.ReadKey();
                              Console.WriteLine();
                              continue;
                        }

                        break;
                  }


                  // add student...
                  Student.studentsList.Add(new Student(_firstName, _lastName, float.Parse(_gpa)));
            }
      }
}
