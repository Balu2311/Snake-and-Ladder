using System;

namespace Snake
{
    class Program
    {
        public static int rollDice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            return dice;
        }
        public static int checkOption()
        {
            Random random = new Random();
            int option = random.Next(1, 4);
            return option;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome To Snake and Ladder Game***");
            int playerPosition = 0, countRound = 0;
            while (playerPosition != 100)
            {
                int playerDice = rollDice();
                int option = checkOption();
                int winPosition = 100;
                countRound++;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Player Got Ladder.");
                        playerPosition += playerDice;
                        if (playerPosition > winPosition)
                        {
                            playerPosition -= playerDice;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Player got Snake.");
                        if ((playerPosition - playerDice) < 0)
                        {
                            playerPosition = 0;
                        }
                        else
                        {
                            playerPosition -= playerDice;
                        }
                        break;
                    default:
                        Console.WriteLine("Player not playing.");
                        break;
                }
                Console.WriteLine($"Roll_Dice_Count:{ countRound } :PlayerPosition: {playerPosition}");
                if (playerPosition == winPosition)
                {
                        Console.WriteLine("----------Player_Won----------");
                        Console.WriteLine("Number of times dice was played : {0}", countRound);
                }
                    
            }
        }
    }
}
