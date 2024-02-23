using System;
using System.Drawing;
using System.Numerics;
using Lab6CSharp.src;

namespace Lab6CSharp {
    internal class Program {
        static void Main(string[] args) {
            int number = 1;

            while (number != 0) {
                Console.Write("Input task number [1-2], [0] to exit: ");

                try {
                    string? input = Console.ReadLine();

                    if (input != null) {
                        number = int.Parse(input);

                        switch (number) {
                            case 0:
                                return;

                            case 1:
                                task1(); // Testing task 1
                                break;

                            case 2:
                                task2(); // Testing task
                                break;

                            default:
                                break;
                        }
                    } else {
                        Console.WriteLine("Nothing provided. Exiting...");
                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex.ToString());
                }

                Console.WriteLine();
            }
        }

        static void task1() {
            Console.WriteLine("|===~        Testing task 1.1        ~===|");

            // Create a student object
            IPerson student = new Student {
                Name = "John Doe",
                Age = 20,
                StudentId = 12345,
                Major = "Computer Science"
            };

            // Display student information
            Console.WriteLine("Student Information:");
            student.Show();
            Console.WriteLine();

            // Create a teacher object
            IPerson teacher = new Teacher {
                Name = "Jane Smith",
                Age = 35,
                SubjectTaught = "Mathematics",
                YearsOfExperience = 10
            };

            // Display teacher information
            Console.WriteLine("Teacher Information:");
            teacher.Show();
            Console.WriteLine();

            // Create a department head object
            IPerson deptHead = new DepartmentHead {
                Name = "Dr. William Brown",
                Age = 45,
                SubjectTaught = "Computer Science",
                YearsOfExperience = 20,
                Department = "Computer Science Department"
            };

            // Display department head information
            Console.WriteLine("Department Head Information:");
            deptHead.Show();
            Console.WriteLine();
        }

        static void task2() {
            Console.WriteLine("|===~        Testing task 2.1        ~===|");

            // Interface list
            var figures = new List<IFigure>();

            // Creating entyties
            var rectangle = new Lab6CSharp.src.Rectangle(5, 10);
            var circle = new Circle(3);
            var triangle = new Triangle(3, 4, 5);

            // Adding figures to the list
            figures.Add(rectangle);
            figures.Add(circle);
            figures.Add(triangle);

            // Displaying information about each figure
            foreach (var figure in figures) {
                figure.DisplayInfo();
                Console.WriteLine();
            }

            // Sorting figures by area
            figures.Sort();

            // Displaying after sorting
            Console.WriteLine("Figures after sorting by area:");
            foreach (var figure in figures) {
                figure.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}