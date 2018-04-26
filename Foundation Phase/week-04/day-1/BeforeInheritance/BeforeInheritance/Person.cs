using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeInheritance
{
    class Person
    {
        protected string name;
        protected int age;
        protected string gender;

        public Person(string name = "Jane Doe", int age = 30, string gender = "female")
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender}.");
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }

    }
}
