using MementoLib;
using System;

namespace MementoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Game game = new Game();
            game.AddPlayer("Andreas", "Vind", 18, 3);
            game.ShowPlayers();

        }
    }
}
