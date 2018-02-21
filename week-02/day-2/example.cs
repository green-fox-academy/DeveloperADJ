using System;
using System.Collections.Generic;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many do you want to eat?: ");
            int amount = int.Parse(Console.ReadLine());
            EatAllTheDonuts(amount);
            Console.ReadLine();

        }


        //Forr Loop
        public static void EatAllTheDonuts(int numberOfDonutsToEat)
        {
            int donuts = numberOfDonutsToEat;

            for (int i = numberOfDonutsToEat; i > 0; i--)
            {
                Console.WriteLine($"I ate one donut I have {i} donuts left!");
            }

            for (int i = length - 1; i >= 0; i--)
            {

            }





        }



    }









}