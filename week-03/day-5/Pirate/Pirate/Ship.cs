using System;
using System.Collections.Generic;
using System.Text;

namespace Pirate
{
    class Ship
    {
        private List<Pirate> CrewList = new List<Pirate>();

        public string shipName;
        public bool shipFilled = false;
        private Random RandomNumberGenerator = new Random();
        int aliveCrew = 0;
        int deadCrew = 0;
        private Pirate captain;
        private int life = 30;

        public int GetLife()
        {
            return life;
        }

        public Ship(string shipName, Pirate captain)
        {
            this.shipName = shipName;
            this.captain = captain;
        } 

        public void AddCrew(Pirate pirate)
        {
            CrewList.Add(pirate);
        }

        public void Battle(Ship enemy)
        {
            int AttackerRoll = DiceRoll();
            int DefenderRoll = enemy.DiceRoll();
            
            if (enemy.life < 1)
            {
                Graphics.Print(Graphics.Won);
                Console.WriteLine(enemy.shipName + " was defeated!");
                Graphics.ContinueAndClear();
            }
            else
            {
                if (enemy.shipName == "Black Pearl")
                {
                    Graphics.Print(Graphics.PlayerAttack);   
                }
                else
                {
                    Graphics.Print(Graphics.EnemyAttack);
                }
                Console.WriteLine($"{shipName} attacks {enemy.shipName} with an Attack Roll of [{AttackerRoll}]!");
                Console.Write($"{enemy.shipName} took {AttackerRoll} damage! He has {enemy.life} life left.");

                Console.ReadLine();
                Console.Clear();
                enemy.life -= AttackerRoll;
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
