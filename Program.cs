using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int rolledNumber=0 ;
            string rollOrHold;
            int turnScore=0;
            int totalScore = 0;
            int turn=1;
            
            
            Console.WriteLine("====WELCOME TO THE GAME OF PIG...");
            Console.WriteLine("=================================");
            Console.WriteLine("Turn " +turn);
            
           while(true)
            {
                Console.WriteLine("Enter r to roll again and h to hold:");
                rollOrHold = Console.ReadLine();
                if (rollOrHold == "r")
                {

                    

                    rolledNumber = rnd.Next(1, 7);
                    Console.WriteLine("You rolled: " + rolledNumber);
                    if (rolledNumber == 1)
                    {
                        Console.WriteLine("Turn over. No score.");
                        turnScore = 0;
                    }
                    else
                    {

                    
                        turnScore += rolledNumber;

                        Console.WriteLine(" * Your turn score is " + turnScore + " and your total score is " +totalScore+ " . ");
                        Console.WriteLine(" * If you hold you will have " + (turnScore+totalScore) + " points.");
                    }
                }
                else if(rollOrHold == "h")
                {
                 
                    totalScore = turnScore;
                    Console.WriteLine("Your turn score is " + turnScore + " and your total score is " + totalScore);
                    
                    turnScore = 0;
                    turn++;
                    

                    Console.WriteLine("Turn " + turn);
                    Console.WriteLine("-------------------");
                }
                if ((turnScore+totalScore) >= 20)
                {


                    Console.WriteLine("You Win!. You finished in " + turn + " turns.");
                    Console.WriteLine("\n Game Over!");
                    Environment.Exit(0);
                }
            }



        }


    }
}










