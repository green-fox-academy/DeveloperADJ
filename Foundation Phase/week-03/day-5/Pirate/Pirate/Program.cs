using System;
using System.IO;

namespace Pirate
{
    class Program
    {
        static Pirate Player = new Pirate("", true);

        public static string playerShipName = "";
        public static Ship PlayerShip = new Ship("", Player);

        public static Pirate Enemy = new Pirate("Blackbeard", true);

        public static Ship EnemyShip = new Ship("Black Pearl", Enemy);

        static void Main(string[] args)
        {
            PlayerSetup();
            
            do
            {
                PlayerShip.Battle(EnemyShip);
                EnemyShip.Battle(PlayerShip);

            } while (PlayerShip.GetCrewAmount() > 0 && PlayerShip.GetCrewAmount() > 0);
           

        }

        public static void PlayerSetup()
        {
            do
            {
                Graphics.Print(Graphics.Intro);
                Console.WriteLine("\"Hello Captain, what is your name?\"\n");
                Console.Write("Enter Name: ");
                Player.name = Console.ReadLine();
            } while (Player.name == "");

            Graphics.Print(Graphics.Player);
            Console.WriteLine($"\"I see, so you are Captain {Player.name}.\"\n");
            Graphics.ContinueAndClear();

            Graphics.Print(Graphics.Intro);
            Console.WriteLine("\"Well, you have much to do so let's get started!\"\n");
            Graphics.ContinueAndClear();

            Graphics.Print(Graphics.YourShip);
            Console.WriteLine("\"This is your ship, you will use it to fight other ships and steal their treasure.\"\n");
            Graphics.ContinueAndClear();

            do
            {
                Graphics.Print(Graphics.YourShip);
                Console.WriteLine("What is the name of your ship?");
                Console.Write("Enter Ship Name: ");
                PlayerShip.shipName = Console.ReadLine();
            } while (PlayerShip.shipName == "");

            PlayerShip.FillShip();
            Console.WriteLine($"Captain {Player.name} and {PlayerShip.GetCrewAmount()} pirates set sail on {PlayerShip.shipName}!\n");
            Graphics.ContinueAndClear();
            Graphics.Print(Graphics.ShipStatus);
            PlayerShip.CountCrew();
            Graphics.ContinueAndClear();
        }

        public static void EnemySetup()
        {
            Graphics.Print(Graphics.Villain);
            Console.WriteLine($"This is Captain {Enemy.name}, he is your enemy.\n");
            EnemyShip.FillShip();
            Console.WriteLine($"Captain Blackbeard and {EnemyShip.GetCrewAmount()} of his pirate crew boarded his ship!\n");
            EnemyShip.CountCrew();
            Graphics.ContinueAndClear();
        }

        public static void Battle(Ship playership, Ship enemyship)
        {
            playership.Battle(enemyship);
            enemyship.Battle(playership);
        }

    }
}
