using System;
using System.Collections.Generic;
using System.Text;

namespace Pirate
{
    class Ship
    {
        private List<Pirate> CrewList = new List<Pirate>();

        string shipName;
        public bool shipFilled = false;
        private Random RandomNumberGenerator = new Random();
        int aliveCrew = 0;
        int deadCrew = 0;


        public Ship(string shipName)
        {
            this.shipName = shipName;
        }

        public void AddCrew(Pirate pirate)
        {
            CrewList.Add(pirate);
        }

        public void Battle(Ship enemy)
        {
            int AttackerRoll = DiceRoll();
            int DefenderRoll = enemy.DiceRoll();

            Console.WriteLine($"{shipName} attacked {enemy.shipName}!\n");
            Graphics.ContinueAndClear();

            if (AttackerRoll > DefenderRoll)
            {
                Graphics.Print(Graphics.ships);
                Console.WriteLine($"HIT {enemy.shipName}! {AttackerRoll} crew members were killed!\n");

                for (int i = 0; i < AttackerRoll; i++)
                {
                    if (enemy.CrewList.Count < 0) return;
                        enemy.CrewList[0].isDead = true;                    
                }
                enemy.CountCrew();

            }
            else
            {
                Graphics.Print(Graphics.ships);
                Console.WriteLine("MISS");
                enemy.CountCrew();
            }
        }

        public int GetCrewAmount()
        {
            return CrewList.Count;
        }

        public int DiceRoll()
        {
            return RandomNumberGenerator.Next(1, 10);
        }

        public void CountCrew()
        {
            deadCrew = 0;
            aliveCrew = 0;
            for (int i = 0; i < CrewList.Count; i++)
            {
                if (CrewList[i].isDead)
                {
                    deadCrew++;
                }
                else
                {
                    aliveCrew++;
                }

            }
            Console.WriteLine($"[{shipName} Stats]\nCrew Alive: {aliveCrew}\nCrew Dead: {deadCrew}\n");
        }

        public void FillShip()
        {

            if (!shipFilled)
            {

                int randomNumber = RandomNumberGenerator.Next(5, 10);
                AddCrew(new Pirate($"Captain of the {shipName}", true));


                for (int i = 0; i < randomNumber; i++)
                {
                    AddCrew(new Pirate($"Pirate{1}"));
                }

                shipFilled = true;
            }
            else
            {
                Console.WriteLine($"The {shipName} is already full of crew!");
            }
        }
    }
}
