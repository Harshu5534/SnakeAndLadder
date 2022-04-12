using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            SnakeAndLadderGame game = new SnakeAndLadderGame();
            Console.WriteLine(game.DieRoll());
            game.Game();
            game.TwoPlayers();
       
        }
    }

    
}