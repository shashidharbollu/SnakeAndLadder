using System;
using SnakeAndLadderGAME;
public class program
{
    public static void Main(String[] args)
    {
        ladder game = new ladder();
        int start = game.dieRoll();
        Console.WriteLine("Welcome in the Game, Your Position is: " + "****" + start + "****");
    }
}