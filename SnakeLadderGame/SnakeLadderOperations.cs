using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderGame
{
    class SnakeLadderOperations
    {
        public int STARTING_POSITION = 0;
        Random random = new Random();
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int NO_PLAY = 0;

        public int DiceRoll()
        {
            int diceValue = (random.Next(6) + 1);
            return diceValue;
        }

        public void GamePlay(int diceValue)
        {
            int playerPosition = STARTING_POSITION;
            int action = random.Next(3);
            switch (action)
            {
                case NO_PLAY:
                    if (playerPosition < 0)
                    {
                        playerPosition = STARTING_POSITION;
                    }
                    Console.WriteLine("Current Snake Position "+ playerPosition);
                    break;
                case LADDER:
                    playerPosition = playerPosition + diceValue;
                    Console.WriteLine("Current Ladder Position is " + playerPosition);
                    break;
                case SNAKE:
                    playerPosition = playerPosition - diceValue;
                    if (playerPosition < 0)
                    {
                        playerPosition = STARTING_POSITION;
                    }
                    Console.WriteLine("No Play Position " + playerPosition);
                    break;
            }
        }
    }
}
