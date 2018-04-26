using System;
using System.Collections.Generic;
using System.IO;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read all data from 'log.txt'.
            // Each line represents a log message from a web server
            // Write a function that returns an array with the unique IP adresses.
            // Write a function that returns the GET / POST request ratio.

            string file = "log.txt";

            uniqueIpAddresses(file);
            Console.WriteLine($"GET/POST Ratio: {getPostRatio(file)}");
            
            Console.ReadLine();
        }

        static string[] uniqueIpAddresses(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            string[] ipAdresses = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                ipAdresses[i] = lines[i].Substring(27, 11);
            }
            //index 27 - 37 = IP's

            for (int i = 0; i < ipAdresses.Length; i++)
            {
                Console.WriteLine(ipAdresses[i]);
            }

            return ipAdresses;
        }

        public static double getPostRatio(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            double getCount = 0;
            double postCount = 0;


            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("GET"))
                {
                    getCount++;
                }
                else if (lines[i].Contains("POST"))
                {
                    postCount++;
                }
            }

            Console.WriteLine($"GETS: {getCount}");
            Console.WriteLine($"POSTS: {postCount}");

            return getCount / postCount;
        }


    }
}