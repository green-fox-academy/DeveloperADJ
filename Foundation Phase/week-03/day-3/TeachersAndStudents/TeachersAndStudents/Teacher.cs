using System;
using System.Collections.Generic;
using System.Text;

namespace TeachersAndStudents
{
    class Teacher
    {
        public void Teach(Student student)
        {
            Console.WriteLine("The teacher teaches.");
            student.Learn();
        }

        public void Answer()
        {
            Console.WriteLine("The teacher answers.");
        }
    }
}
