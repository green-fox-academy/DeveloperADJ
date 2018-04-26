using System;
using System.Collections.Generic;

namespace SolarSystem
{
    public class SolarSystem
    {
        public static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };


            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct list.

            Console.WriteLine(PutSaturn(planetList));
            Console.ReadLine();
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune", "Saturn"
        }

        public static string PutSaturn(List<string> planets)
        {
            planets.Insert(planets.Count, "Saturn");
            string printablePlanets = "";

            foreach (var planet in planets)
            {
                printablePlanets += $"\"{planet}\", ";
            }

            printablePlanets = printablePlanets.Remove(printablePlanets.Length -2, 2);

            return printablePlanets;
        }


    }


}