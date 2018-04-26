using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeInheritance
{
    class Student : Person, ICloneable
    {
        string previousOrganization;
        int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization = "The School of Life", int skippedDays = 0): base(name, age, gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganization = previousOrganization;
            this.skippedDays = skippedDays;
        }

        public Student()
        {
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender}.");
        }

        public override void GetGoal()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old gender from {previousOrganization} who skipped {skippedDays} days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }

        public object Clone()
        {
            return new Student(this.name, this.age, this.gender, this.previousOrganization, this.skippedDays);
        }
    }
}
