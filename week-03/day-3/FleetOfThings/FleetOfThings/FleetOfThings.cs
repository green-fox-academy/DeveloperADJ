using System;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            var fleet = new Fleet();

            var Milk = new Thing("Milk", false);
            fleet.Add(Milk);

            var RemoveObstacles = new Thing("Remove the obstacles", false);
            fleet.Add(RemoveObstacles);

            var StandUp = new Thing("Stand up", true);
            fleet.Add(StandUp);

            var EatLunch = new Thing("Eat lunch", true);
            fleet.Add(EatLunch);

            var DoMath = new Thing("Do math", false);
            fleet.Add(DoMath);

            var TestAgain = new Thing("Test Again", true);
            fleet.Add(TestAgain);

            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also


            for (int i = 0; i < Fleet.Things.Count; i++)
            {
                Console.Write($"{i+1}. ");

                if (Fleet.Things[i].Completed == true)
                {
                    Console.Write("[x] ");
                }
                else
                {
                    Console.Write("[ ] ");
                }
                Console.Write(Fleet.Things[i].Name + "\n");
            }
            Console.ReadLine();
        }
    }
}