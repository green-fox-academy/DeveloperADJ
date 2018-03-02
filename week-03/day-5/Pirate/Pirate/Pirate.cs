using System;
using System.Collections.Generic;
using System.Text;

namespace Pirate
{
    class Pirate
    {
        static int rumCounter = 0;
        static string message = "\"Pour me anudder!\"\n";
        public bool isDead = false;
        public string name;
        bool isCaptain;
        public static int totalNumberOfPirates = 0;

        public Pirate(string name = "Default Pirate", bool isCaptain = false)
        {
            this.name = name;
            this.isCaptain = isCaptain;
            totalNumberOfPirates++;
        }

        public void DrinkSomeRum(int amount = 1)
        {
            Console.Write("Drink: ");
            if (!isDead)
            {
                Console.WriteLine($"{name} drinks some rum.\n");
                rumCounter += amount;
            }
            else
            {
                Console.WriteLine($"{name} is dead\n");
            }
        }

        public void HowsItGoingMate()
        {
            Console.Write("Speak: ");
            if (!isDead)
            {
                if (rumCounter > 4)
                {
                    message = $"\"Arghh, I'm {name}. How d'ya d'ink its goin?\", the pirate passes out and sleeps it off.\n";
                }
            }
            else
            {
                message = $"Cannot speak: {name} is dead.\n";
            }
            Console.WriteLine(message);
        }

        public void Die()
        {
            Console.Write("Die: ");
            Console.WriteLine($"{name} dies.\n");
            isDead = true;
            totalNumberOfPirates--;
        }

        public void Brawl(Pirate enemy)
        {
            Random rng = new Random();
            int randomNumber = rng.Next(1, 4);

            Console.Write("Brawl: ");

            if (enemy.isDead)
            {
                Console.WriteLine($"{enemy.name} is already dead.\n");
            }
            else if (isDead)
            {
                Console.WriteLine($"{name} is dead.\n");
            }
            else
            {
                Console.Write($"{name} started a brawl with {enemy.name}!");
                if (randomNumber.Equals(1))
                {
                    isDead = true;
                    Console.WriteLine($" {name} died.\n");
                    totalNumberOfPirates--;
                }
                else if (randomNumber.Equals(2))
                {
                    enemy.isDead = true;
                    Console.WriteLine($" {enemy.name} died.\n");
                    totalNumberOfPirates--;
                }
                else if (randomNumber.Equals(3))
                {
                    isDead = true;
                    enemy.isDead = true;
                    Console.WriteLine($" Both pirates died.\n");
                    totalNumberOfPirates -= 2;
                }

            }
        }
    }
}

