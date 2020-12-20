using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderGame
{
    class SnakeLadderOperations
    {
        public const int STARTING_POSITION = 0;
        public int WINING_POSITION = 100;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int NO_PLAY = 0;
        static Random random = new Random();

        public static int DiceRoll()
        {
            int diceValue = random.Next(6) + 1;
            return diceValue;
        }

        public void GamePlay()
        {
            int playerPosition = STARTING_POSITION;
            while (playerPosition < WINING_POSITION)
            {
                int action = random.Next(3);
                Console.WriteLine("Action Value= "+action);
                int diceValue = DiceRoll();
                switch (action)
                {
                    case NO_PLAY:

                        if (playerPosition < 0)
                        {
                            playerPosition = STARTING_POSITION;
                        }
                        Console.WriteLine("Current No Play Position " + playerPosition);
                        break;
                    case LADDER:
                        playerPosition = Convert.ToInt32(playerPosition + diceValue);
                        Console.WriteLine("Current Ladder Position is " + playerPosition);
                        break;
                    case SNAKE:
                        playerPosition = Convert.ToInt32(playerPosition - diceValue); ;
                        if (playerPosition < 0)
                        {
                            playerPosition = STARTING_POSITION;
                        }
                        Console.WriteLine("Current Snake Position is " + playerPosition);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }
            }
        }
    }
}
