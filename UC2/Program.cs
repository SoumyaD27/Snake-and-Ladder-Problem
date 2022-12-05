using System;
namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder Game");
            Console.WriteLine("Player roll the Dice: ");
            Random random = new Random();
            int n1 = random.Next(0,7);
            Console.WriteLine("{0} is the number of steps the player need to move.", n1);
        }
    }
}