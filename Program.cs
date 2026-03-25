using System;

namespace Competition2_group4
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }

        public Person(string name, string email, string id)
        {
            Name = name;
            Email = email;
            ID = id;
        }
    }

    public class Staff : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }

        public Staff(string name, string email, string id, string position, string department)
            : base(name, email, id)
        {
            Position = position;
            Department = department;
        }
    }

    public class Student : Person
    {
        public string Major { get; set; }
        public int GraduationYear { get; set; }

        public Student(string name, string email, string id, string major, int graduationYear)
            : base(name, email, id)
        {
            Major = major;
            GraduationYear = graduationYear;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            Staff st1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");

            Console.WriteLine("Student: " + s1.Name + " - " + s1.ID);
            Console.WriteLine("Staff: " + st1.Name + " - " + st1.ID);
        }
    }
}
