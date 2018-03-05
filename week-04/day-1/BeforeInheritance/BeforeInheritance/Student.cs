using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeInheritance
{
    class Student
    {
        string name;
        int age;
        string gender;
        string previousOrganization;
        int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public Student()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a age year old {gender}.");
        }

        public void GetGoal()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old gender from {previousOrganization} who skipped {skippedDays} days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }

    }
}
