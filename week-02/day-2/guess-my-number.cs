using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercise
            Write a program where the program chooses a number between 1 and 100. The player is then asked to enter a guess. 
            If the player guesses wrong, then the program gives feedback and ask to enter an other guess until the guess is correct.

            Make the range customizable (ask for it before starting the guessing).
            You can add lives. (optional)
            Example
            I've the number between 1-100. You have 5 lives.

            20

            Too high. You have 4 lives left.

            10

            Too low. You have 3 lives left.

            15

            Congratulations. You won!*/

            Console.WriteLine("In this game you have to guess a number between two values!\n\n");

            Console.Write("How many lives would you like to play with?: ");
            int lives = int.Parse(Console.ReadLine());

            Console.Write("What would you like the minimum number to be?: ");
            int minNumber = int.Parse(Console.ReadLine());

            Console.Write("What would you like the maximum number to be?: ");
            int maxNumber = int.Parse(Console.ReadLine());

            Random randomNumber = new Random();

            int winningNumber = randomNumber.Next(minNumber, maxNumber);
            //Console.WriteLine($"(The winning number is {winningNumber})");
            int guessedNumber;
            bool gameIsFinished = false;

            Console.WriteLine("To start, guess a number!: ");
            guessedNumber = int.Parse(Console.ReadLine());

            while (gameIsFinished != true)
            {

                if (lives < 1)
                {
                    Console.WriteLine("You are out of lives!");
                    Console.ReadLine();
                }
                else
                {
                    if (guessedNumber == winningNumber)
                    {
                        Console.WriteLine($"Congratulations the number was {winningNumber}!");
                        gameIsFinished = true;
                        Console.ReadLine();
                    }
                    else
                    {
                        lives--;
                        Console.WriteLine($"Oh no, You lost a life! You have {lives} left!");
                        Console.WriteLine("Try Again. Guess a number!: ");
                        guessedNumber = int.Parse(Console.ReadLine());
                    }
                }
 
            }




        }


    }
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercise
            Write a program where the program chooses a number between 1 and 100. The player is then asked to enter a guess. 
            If the player guesses wrong, then the program gives feedback and ask to enter an other guess until the guess is correct.

            Make the range customizable (ask for it before starting the guessing).
            You can add lives. (optional)
            Example
            I've the number between 1-100. You have 5 lives.

            20

            Too high. You have 4 lives left.

            10

            Too low. You have 3 lives left.

            15

            Congratulations. You won!*/

            Console.WriteLine("In this game you have to guess a number between two values!\n\n");

            Console.Write("How many lives would you like to play with?: ");
            int lives = int.Parse(Console.ReadLine());

            Console.Write("What would you like the minimum number to be?: ");
            int minNumber = int.Parse(Console.ReadLine());

            Console.Write("What would you like the maximum number to be?: ");
            int maxNumber = int.Parse(Console.ReadLine());

            Random randomNumber = new Random();

            int winningNumber = randomNumber.Next(minNumber, maxNumber);
            //Console.WriteLine($"(The winning number is {winningNumber})");
            int guessedNumber;
            bool gameIsFinished = false;

            Console.WriteLine("To start, guess a number!: ");
            guessedNumber = int.Parse(Console.ReadLine());

            while (gameIsFinished != true)
            {

                if (lives < 1)
                {
                    Console.WriteLine("You are out of lives!");
                    Console.ReadLine();
                }
                else
                {
                    if (guessedNumber == winningNumber)
                    {
                        Console.WriteLine($"Congratulations the number was {winningNumber}!");
                        gameIsFinished = true;
                        Console.ReadLine();
                    }
                    else
                    {
                        lives--;
                        Console.WriteLine($"Oh no, You lost a life! You have {lives} left!");
                        Console.WriteLine("Try Again. Guess a number!: ");
                        guessedNumber = int.Parse(Console.ReadLine());
                    }
                }
 
            }




        }


    }
}