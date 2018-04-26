using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeInheritance
{
    class Sponsor : Person
    {
        string company;
        int hiredStudents;

        public Sponsor(string name = "Jane Doe", int age = 30, string gender = "female", string company = "Google", int hiredStudents = 0): base(name, age, gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;

            this.company = company;
            this.hiredStudents = hiredStudents;
        }

        public Sponsor()
        {
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old gender who represents {company} and hired {hiredStudents} students so far.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public void Hire()
        {
            hiredStudents++;
        }


    }
}
