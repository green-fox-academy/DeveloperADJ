using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTX = int.Parse(inputs[2]); // Thor's starting X position
        int initialTY = int.Parse(inputs[3]); // Thor's starting Y position

        int thorX = int.Parse(inputs[2]);
        int thorY = int.Parse(inputs[3]);
        
        bool movesWest = false;
        bool movesEast = false;
        bool movesNorth = false;
        bool movesSouth = false;
            
        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");


            // A single line providing the move to be made: N NE E SE S SW W or NW
            
            if (lightY > thorY)
            {
                 
                movesSouth = true;
            }
            else 
            {
                movesNorth = true;    
            }

            if (thorX+3 == lightY){
                if (movesWest && movesSouth){
                    Console.WriteLine("SW");
                    //thorX--;
                    //thorY++;
                } else if (movesWest && movesNorth){
                    Console.WriteLine("NW");
                    //thorX--;
                    //thorY--;
                } else if (movesEast && movesSouth){
                    Console.WriteLine("SE");
                    //thorX++;
                    //thorY++;
                } else if (movesEast && movesNorth) {
                    Console.WriteLine("NE");
                    //thorX++;
                    //thorY--;
                } 
            }
            else 
            {
                if (lightX <= thorX){
                    Console.WriteLine("W");   
                    thorX--;
                    movesWest = true;
                }
                else if (lightX >= thorX)
                {
                    Console.WriteLine("E");    
                    thorX++;
                    movesEast = true;
                }
                
                if (thorX == lightX) {
                    
                    if(thorY >= lightY){
                        Console.WriteLine("N");
                        thorY--;
                        movesNorth = true;
                    }
                    else
                    {
                        thorY++;
                        Console.WriteLine("S");
                        movesSouth = true;
                    }    
                
                }

            }
            
            Console.Error.WriteLine($"X = {thorX}, Y = {thorY}");
            
            
            
            
            
            
        }
    }
}