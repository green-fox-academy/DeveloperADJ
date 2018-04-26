using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeInheritance
{
    class Mentor : Person
    {
        string level;

        public Mentor(string name, int age, string gender, string level = "intermediate"): base(name, age, gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;

            this.level = level;
        }

        public Mentor()
        {
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender} {level} mentor.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }
    }
}
