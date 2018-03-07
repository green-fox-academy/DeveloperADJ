using System;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            var fleet = new Fleet();

            var Milk = new Thing("Milk", false);
            var RemoveObstacles = new Thing("Remove the obstacles", false);
            var StandUp = new Thing("Stand up", true);
            var EatLunch = new Thing("Eat lunch", true);
            var DoMath = new Thing("Do math", false);
            var TestAgain = new Thing("Test Again", true);

            fleet.Add(Milk);
            fleet.Add(RemoveObstacles);
            fleet.Add(StandUp);
            fleet.Add(EatLunch);
            fleet.Add(DoMath);
            fleet.Add(TestAgain);

            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also

            PrintTodoList(fleet);

            fleet.Things.Sort((b, a) => a.Completed.CompareTo(b.Completed));

            PrintTodoList(fleet);

            fleet.Things.Sort((a, b) => a.Completed.CompareTo(b.Completed));

            PrintTodoList(fleet);

            Console.ReadLine();
        }

        public static void PrintTodoList(Fleet fleet)
        {
            for (int i = 0; i < fleet.Things.Count; i++)
            {
                Console.Write($"{i+1}. [");

                if (fleet.Things[i].Completed.Equals(true))
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(" ");
                }

                Console.Write($"] {fleet.Things[i].Name}");
                Console.WriteLine();
            }
        }


    }
}