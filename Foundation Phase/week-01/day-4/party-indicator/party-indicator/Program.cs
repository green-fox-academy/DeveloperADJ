using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            //
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people

            Console.WriteLine("How many boys will there be at the party?");
            int boysAtParty = int.Parse(Console.ReadLine());

            Console.WriteLine("How many girls will there be at the party?");
            int girlsAtParty = int.Parse(Console.ReadLine());

            if ( boysAtParty == girlsAtParty)
            {
                Console.WriteLine("The party is excellent!");
            }
            else if (boysAtParty == girlsAtParty && (girlsAtParty+boysAtParty) > 20)
            {
                Console.WriteLine("Quite a cool party!");
            }
            else if ((boysAtParty + girlsAtParty) < 20)
            {
                Console.WriteLine("Average part...");
            }
            else if ( girlsAtParty <= 0)
            {
                Console.WriteLine("Sausage party");
            }

            Console.ReadLine();

        }
    }
}