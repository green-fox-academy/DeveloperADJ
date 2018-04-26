using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercise 10 
             * Create a Fox class with 3 properties(name, type, color) 
             * Fill a list with at least 5 foxes, it's up to you how you name/create them! 
             * Write a LINQ Expression to find the foxes with green color! 
             * Write a LINQ Expression to find the foxes with green color and pallida type!*/

            List<Fox> foxes = new List<Fox> {
                new Fox("Johnny", "pallida", "green"),
                new Fox("Mark", "MateType", "red"),
                new Fox("Eddy", "pallida", "orange"),
                new Fox("Fred", "other", "green"),
                new Fox("George", "pallida", "brown"),
                new Fox("Joe", "pallida", "green"),
            };

            //IEnumerable<Fox> greenFoxes = foxes.Where(x => x.color == "green");
            IEnumerable<Fox> greenFoxes = from fox in foxes
                                          where fox.color == "green"
                                          select fox;

            //IEnumerable<Fox> greenPallidaFoxes = foxes.Where(x => x.color == "green" && x.type == "pallida");
            IEnumerable<Fox> greenPallidaFoxes = from fox in foxes
                                                 where fox.color == "green" && fox.type == "pallida"
                                                 select fox;

            foreach (var fox in greenFoxes)
            {
                Console.WriteLine(fox.name + " is a green fox");
            }

            foreach (var fox in greenPallidaFoxes)
            {
                Console.WriteLine(fox.name + " is a green fox of the pallida type");
            }

            Console.ReadLine();
        }
    }
}
