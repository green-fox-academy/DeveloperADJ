using System;
using System.Collections.Generic;

namespace BeforeInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("John", 20, "male");

            Student john2 = john.Clone() as Student;

            john.SkipDays(30);
            john2.GetGoal();
            john.GetGoal();
            Console.ReadLine();
        }
    }
}
