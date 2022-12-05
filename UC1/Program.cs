using System;
namespace UC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder Game");
            Console.WriteLine("First Player roll the Dice: ");
            Random random = new Random();
            int n1 = random.Next(7);
            if (n1==0)
            {
                Console.WriteLine("Start");
            }
            else
            {
                Console.WriteLine("you are not at 0 position");
            }
        }
    }
}