using System;

namespace SnakeAndLadderGAME
{
    class Program
    {
        static void Main(string[] args)
        {
            ladder game = new ladder();
            Console.WriteLine(game.DieRoll());
            game.Game();

        }
    }


}