using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial

            Console.WriteLine("Enter a number and you will get its factorial: ");
            double userNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(Factorio(userNumber));

            Console.ReadLine();
        }

        public static double Factorio (double number)
        {
           

            double counter = number;

            while (counter > 1)
            {
                counter--;

                number *= counter;

                
            }

            return number;
        }
    }
}