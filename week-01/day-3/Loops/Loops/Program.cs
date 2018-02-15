using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class program
    {
        static void Main(string[] args)
        {
            byte weight;
            weight = 75;
            int birthYear = 1994;
            float pi = 3.14f;
            double priceOfCar = 599.999;
            bool isMarried = false;
            char startingLetterOfMyName = 'A';
            string name = "Arno";

      
            Console.Write("Hello\t");
            Console.Write("My name is " + name + " and my name starts with the letter " + startingLetterOfMyName + ".\n");
            Console.WriteLine("The car I like is {0} Ft and Pi is {1}", priceOfCar, pi);
            Console.ReadLine();
        }
    }
}
