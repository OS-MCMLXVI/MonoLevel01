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
                  string operation;


                  do
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

                        if (!Operations.operations.Contains(operation))
                        {
                              Console.WriteLine("Operation non-existing...  Press [ESC] for exit or any other key for continue...");
                              keyPressed = Console.ReadKey();

                              if (keyPressed.Key == ConsoleKey.Escape)
                                    Environment.Exit(0);
                        }

                        if (operation == "ENLIST")
                              Enlist();

                  } while (operation != "DISPLAY");

                  Display();
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
                  Console.WriteLine(">>>>>  Press any key...");
                  Console.ReadKey();
            }


            private static void Enlist()
            {
                  bool _greska = false;
                  string _firstName;
                  string _lastName;
                  string _gpa;
                  float _fgpa;


                  Console.WriteLine();
                  Console.WriteLine("Student:");

                  
                  do
                  {
                        Console.Write("First name............................:  ");
                        _firstName = Console.ReadLine().Trim();

                        if (String.IsNullOrEmpty(_firstName))
                              Console.WriteLine("You need to insert value...");

                  } while (String.IsNullOrEmpty(_firstName));

                  
                  do
                  {
                        Console.Write("Last name.............................:  ");
                        _lastName = Console.ReadLine().Trim();

                        if (String.IsNullOrEmpty(_lastName))
                              Console.WriteLine("You need to insert value...");

                  } while (String.IsNullOrEmpty(_lastName));


                  do
                  {
                        if (_greska)
                              Console.WriteLine("Input number from 1,00 - 5,00 ...");

                        Console.Write("GPA...................................:  ");
                        _gpa = Console.ReadLine().Trim();
                        _greska = true;

                  } while (!(float.TryParse(_gpa, out _fgpa) && _fgpa >= 1.00 && _fgpa <= 5.00));


                  // add student...
                  Student.studentsList.Add(new Student(_firstName, _lastName, float.Parse(_gpa)));
            }
      }
}
