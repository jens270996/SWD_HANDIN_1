using System;
using System.Collections.Generic;
using System.Text;

namespace MementoLib
{
    public class Game:IOriginator
    {
       

        
            private List<Player> players;

            public void AddPlayer(string name, string mission, int troops, int countries)
            {
                players.Add(new Player(name, mission, troops, countries));
            }

            public void RemovePlayer(string name)
            {
                players.RemoveAll(Player => Player.PlayerName == name);
            }
        

        public class Player
        {
            public Player(string name, string mission, int troops, int countries)
            {
                PlayerName = name;
                Mission = mission;
                NumberOfTroops = troops;
                NumberOfCountries = countries;
            }

            public string PlayerName { get; set; }
            private string Mission;
            private int NumberOfTroops;
            private int NumberOfCountries;
        }

        public MementoLib.IMemento Save()
        {
            var gamestate=new GameMementoState();
            foreach(var player in players)
            {
                gamestate.Players.Add(player);
            }

            return new GameMemento(gamestate);

        }

        public void RestoreState(IMemento memento)
        {
            players.Clear();
            var state=memento.MementoState as GameMementoState;
            foreach(var player in state.Players)
            {
                players.Add(player);
            }
        }

        public void ShowPlayers()
        {
            foreach (var item in players)
            {
                Console.WriteLine(item);
            }
        }
    }
}
