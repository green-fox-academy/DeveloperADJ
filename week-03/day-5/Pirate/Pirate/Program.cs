using System;
using System.IO;

namespace Pirate
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName;

            do
            {
                Console.Clear();
                Graphics.Print(Graphics.Intro);
                Console.WriteLine("\"Hello Captain, what is your name?\"\n");
                Console.Write("Enter Name: ");
                playerName = Console.ReadLine();
            } while (playerName == "");

            Console.Clear();
            Graphics.Print(Graphics.Player);
            Console.WriteLine($"\"I see, so you are Captain {playerName}.\"\n");
            Graphics.ContinueAndClear();

            Graphics.Print(Graphics.Intro);
            Console.WriteLine("\"Well, you have much to do so let's get started!\"\n");
            Graphics.ContinueAndClear();

            Graphics.Print(Graphics.YourShip);
            Console.WriteLine("\"This is your ship, you will use it to fight other ships and steal their treasure.\"\n");
            Graphics.ContinueAndClear();

            Graphics.Print(Graphics.ShipStatus);
            Ship PlayerShip = new Ship("Golden Ship");
            PlayerShip.FillShip();
            Console.WriteLine($"Captain {playerName} and {PlayerShip.GetCrewAmount()} pirates set sail on the ship!\n");
            Graphics.ContinueAndClear();

            Graphics.Print(Graphics.ShipStatus);
            PlayerShip.CountCrew();
            Graphics.ContinueAndClear();

            Graphics.Print(Graphics.Villain);
            Console.WriteLine("This is Captain Blackbeard, he is your enemy.\n");
            Ship EnemyShip = new Ship("Skull Ship");
            EnemyShip.FillShip();
            Console.WriteLine($"Captain Blackbeard and {EnemyShip.GetCrewAmount()} of his pirate crew boarded his ship!\n");
            EnemyShip.CountCrew();
            Graphics.ContinueAndClear();

            do
            {
                Graphics.Print(Graphics.ships);
                PlayerShip.Battle(EnemyShip);
                Graphics.ContinueAndClear();

                Graphics.Print(Graphics.ships);
                EnemyShip.Battle(PlayerShip);
                Graphics.ContinueAndClear();

            } while (PlayerShip.GetCrewAmount() > 0 && EnemyShip.GetCrewAmount() > 0);
                
            if (PlayerShip.GetCrewAmount() > EnemyShip.GetCrewAmount())
            {
                Graphics.Print(Graphics.won);
                Console.WriteLine("You Have Defeated The Enemy!");
            }
            else
            {
                Graphics.Print(Graphics.lost);
                Console.WriteLine("You Were Defeated!");
            }
            Graphics.ContinueAndClear();
            
        }
    }
}
