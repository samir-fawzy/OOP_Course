using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Student_System
{
    class Student
    {
        public string Name { get; set; }    
        public string Course { get; set; }
        public string Subject { get; set; }
        public string University { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public static int studentCount = 0;

        public Student(string name, string course, string subject, string university, string email, string phone)
        {
            Name = name;
            Course = course;
            Subject = subject;
            University = university;
            Email = email;
            Phone = phone;

            studentCount++;
        }

        public Student(string name,string course,string subject)
        {
            Name = name;
            Course = course;
            Subject = subject;
            University = null;
            Email = null;
            Phone = null;
            studentCount++;
        }

        public Student(string name)
        {
            Name = name;
            Course = null;
            Subject = null;
            University = null;
            Email = null;
            Phone = null;
            studentCount++;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Name       : {Name ?? "unavailable"}");
            Console.WriteLine($"Course     : {Course ?? "unavailable"}");
            Console.WriteLine($"Subject    : {Subject ?? "unavailable"}");
            Console.WriteLine($"University : {University ?? "unavailable"}");
            Console.WriteLine($"Email      : {Email ?? "unavailable"}");   
            Console.WriteLine($"Phone      : {Phone ?? "unavailable"}");

            Console.WriteLine();
        }

    }
}
