using System;
using System.Collections.Generic;
using System.Text;

namespace TeachersAndStudents
{
    class Student
    {
        public void Learn()
        {
            Console.WriteLine("The student learns.");
        }

        public void Question(Teacher teacher)
        {
            Console.WriteLine("The student asks a question.");
            teacher.Answer();
        }
    }
}
