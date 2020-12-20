using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderGame
{
    class SnakeLadderOperations
    {
        public const int STARTING_POSITION = 0;
        public const int WINING_POSITION = 100;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int NO_PLAY = 0;
        static int action = 0;
        static string task = "";
        static Random random = new Random();

        public static int DiceRoll()
        {
            int diceValue = random.Next(6) + 1;
            return diceValue;
        }

        public static int DiceCount(int diceCount)
        {
            diceCount++;
            return diceCount;
        }

        public static int GamePlay(int playerPosition, int diceCount)
        {
            int diceValue = 0;
            if (playerPosition < WINING_POSITION)
            {
                action = random.Next(3);
                diceValue = DiceRoll();
                switch (action)
                {
                    case NO_PLAY:
                        if (playerPosition < 0)
                        {
                            playerPosition = STARTING_POSITION;
                        }
                        task = "NoPlay";
                        break;
                    case LADDER:
                        int limit = playerPosition + diceValue;
                        if (limit <= WINING_POSITION)
                        {
                            playerPosition = Convert.ToInt32(playerPosition + diceValue);
                        }
                        task = "Ladder";
                        break;
                    case SNAKE:
                        playerPosition = Convert.ToInt32(playerPosition - diceValue); ;
                        if (playerPosition < 0)
                        {
                            playerPosition = STARTING_POSITION;
                        }
                        task = "Snake";
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }
            Console.WriteLine(" | Dice: " + diceValue + " for " + task + " and Current Position : " + playerPosition);
            if (action == 1  && playerPosition < WINING_POSITION)
            {
                diceCount = DiceCount(diceCount);
                GamePlay(playerPosition, diceCount);
            }
            return playerPosition;
        }
        public void TwoPlayersGamePlay()
        {
            int player1Position = STARTING_POSITION;
            int player2Position = STARTING_POSITION;
            int diceCount = 0;
            Console.WriteLine("Game Started by two player");
            while (player1Position < WINING_POSITION && player2Position < WINING_POSITION)
            {
                Console.WriteLine("Player 1 :-  ");
                diceCount = DiceCount(diceCount);
                player1Position = GamePlay(player1Position, diceCount);
                
                Console.WriteLine("-------------------------------------------------------------------------------------------------- ");
                Console.WriteLine("Player 2 :-  ");
                player2Position = GamePlay(player2Position, diceCount);
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
            }
            if (player1Position == WINING_POSITION)
            {
                Console.WriteLine();
                Console.WriteLine("Player 1 Won The Match ");
            }
            else if (player2Position == WINING_POSITION)
            {
                Console.WriteLine();
                Console.WriteLine("Player 2 Won The Match ");
            }
            Console.WriteLine("Total Dice Count of both Players " + diceCount);
        }
    }
}
