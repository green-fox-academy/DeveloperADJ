using System;

namespace TeachersAndStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create Student and Teacher classes
            Student
            learn()
            question(teacher) -> calls the teachers answer method
            Teacher
            teach(student) -> calls the students learn method
            answer()*/

            Teacher myTeacher = new Teacher();
            Student me = new Student();

            me.Question(myTeacher);
            myTeacher.Teach(me);

            Console.ReadLine();
        }
    }
}
