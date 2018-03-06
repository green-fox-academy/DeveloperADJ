using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeInheritance
{
    class Cohort
    {
        string name;
        List<Student> students = new List<Student>();
        List<Mentor> mentors = new List<Mentor>();

        public Cohort(string name)
        {
            this.name = name;
            
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine($"The {name} cohort has {students.Count} students and {mentors.Count} mentors.");
        }
    }
}
