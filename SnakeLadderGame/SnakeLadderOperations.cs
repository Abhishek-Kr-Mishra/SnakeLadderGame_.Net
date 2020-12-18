using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadderGame
{
    class SnakeLadderOperations
    {
        public int STARTING_POSITION = 0;
        Random random = new Random();

        public void DiceRoll()
        {
            int dice = (random.Next(6) + 1);
            Console.WriteLine("Dice Number  " + dice);
        }
    }
}
