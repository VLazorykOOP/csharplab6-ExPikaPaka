using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6CSharp.src {
    public interface IPerson : IComparable<IPerson> {
        string Name { get; set; }
        int Age { get; set; }
        void Show();
    }

    public class Person : IPerson {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Show() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }

        public int CompareTo(IPerson other) {
            return Age.CompareTo(other.Age);
        }
    }

    public class Student : IPerson {
        public string Name { get; set; }
        public int Age { get; set; }
        public int StudentId { get; set; }
        public string Major { get; set; }

        public virtual void Show() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Major: {Major}");
        }

        public int CompareTo(IPerson other) {
            return Age.CompareTo(other.Age);
        }
    }

    public class Teacher : IPerson {
        public string Name { get; set; }
        public int Age { get; set; }
        public string SubjectTaught { get; set; }
        public int YearsOfExperience { get; set; }

        public virtual void Show() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Subject Taught: {SubjectTaught}");
            Console.WriteLine($"Years of Experience: {YearsOfExperience}");
        }

        public int CompareTo(IPerson other) {
            return Age.CompareTo(other.Age);
        }
    }

    public class DepartmentHead : Teacher {
        public string Department { get; set; }

        public override void Show() {
            base.Show();
            Console.WriteLine($"Department Head of: {Department}");
        }

        public int CompareTo(IPerson other) {
            return Age.CompareTo(other.Age);
        }
    }
}
