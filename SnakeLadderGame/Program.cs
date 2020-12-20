using System;

namespace SnakeLadderGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game");
            SnakeLadderOperations snakeLadderOperations = new SnakeLadderOperations();
            snakeLadderOperations.TwoPlayersGamePlay();
        }
    }
}
