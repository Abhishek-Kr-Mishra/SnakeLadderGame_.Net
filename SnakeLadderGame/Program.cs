using System;

namespace SnakeLadderGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game");
            SnakeLadderOperations snakeLadderOperations = new SnakeLadderOperations();

            int diceValue = snakeLadderOperations.DiceRoll();
            snakeLadderOperations.GamePlay(diceValue);
        }
    }
}
