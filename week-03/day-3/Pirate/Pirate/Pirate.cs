using System;
using System.Collections.Generic;
using System.Text;

namespace Pirate
{
    class Pirate
    {
        static int rumCounter = 0;
        static string message = "\"Pour me anudder!\"";
        static bool isDead = false;

        public static void DrinkSomeRum(int amount = 1)
        {   if (!isDead)
            {
                rumCounter += amount;
            }
            else
            {
                Console.WriteLine("He's dead");
            } 
        }

        public static void HowsItGoingMate()
        {
            if (!isDead)
            {
                if (rumCounter > 4)
                {
                    message = "\"Arghh, I'ma Pirate. How d'ya d'ink its goin?\", the pirate passes out and sleeps it off.";
                }
            }
            else
            {
                message = "he's dead";
            }
            Console.WriteLine(message);
        }

        public static void Die()
        {
            Console.WriteLine("The pirate dies.");
            isDead = true;
        }
    }
}

