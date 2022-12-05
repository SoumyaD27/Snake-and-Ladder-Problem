using System;
using System.Collections;
using System.Collections.Generic;
namespace UC3
{
    class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder Game");
            Console.WriteLine("Player roll the Dice: ");
            Random random = new Random();
            int n1 = random.Next(0, 7);
            Console.WriteLine("{0} is the number of steps the player need to move.", n1);
            if (n1 < 100)
            {
                string option = "NoPlay,Ladder,Snake";
                switch (option)
                {

                    case "NoPlay":
                        n1 = n1;
                        Console.WriteLine("player stays in the same");
                        break;

                    case "Ladder":
                        n1 = n1 + n1;
                        Console.WriteLine("player moves ahead by the number of position received in the die");
                        break;

                    case "Snake":
                        n1 = n1 - n1;
                        Console.WriteLine("player moves behind by the number of position recived in the dice");
                        break;

                    default:
                        Console.WriteLine("Nothing");
                        break;
                }
            }
        }
    }
}