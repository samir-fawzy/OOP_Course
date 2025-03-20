using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course.Student_System
{
    class StudentTest 
    {
       private static Student[] students;

        public static Student[] Students
        { get { return students; } }

        public static void CreateStudent()
        {
            students = new Student[]
            {
                new Student("Samir Fawzy", "Computer Science", "OOP","Menofia","example@.com","4123484"),
                new Student("Samir Fawzy", "Computer Science", "OOP"),
                new Student("Samir Fawzy"),
            };
        }

    }
}
