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
            game.AddPlayer("Jens", "Støt Andreas", 27, 7);
            game.AddPlayer("Joachim", "Slå", 23, 5);
            Console.WriteLine("Spil efter oprettelse.");
            game.PrintPlayers();
            MementoCaretaker mementoCaretaker = new MementoCaretaker();
            mementoCaretaker.AddMemento(game.Save());
            Console.WriteLine("Der gemmes en memento, så vi kan gå tilbage til dette stadie");
            Console.WriteLine("Nu ændres spilleren Jens");
            game.AlterTroops(2, -5);
            Console.WriteLine("Nu er tropper for jens ændret og der ser sådan her ud:");
            game.PrintPlayers();
            mementoCaretaker.AddMemento(game.Save());
            Console.WriteLine("Nu laves en memento til denne del.");
            Console.WriteLine("Nu kaldes den første memento tilbage.");
            game.RestoreState(mementoCaretaker.GetMementoAtIndex(0));
            Console.WriteLine("Nu er vi tilbage fra starten, og vi printer nu spillets data igen.");
            game.PrintPlayers();
        }
    }
}
