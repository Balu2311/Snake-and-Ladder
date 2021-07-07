using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome To Snake and Ladder Game***");
            int playerPosition = 0;
            int playerDice = rollDice();
            Console.WriteLine("Roll Dice: "  + playerDice);
        }
        public static int rollDice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            return dice;
        }
    }
}
