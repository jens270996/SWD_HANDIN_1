using System;
using System.Collections.Generic;
using System.Text;

namespace MementoLib
{
    public class Game:IOriginator
    {
       

        
            private List<Player> players;

            public void AddPlayer(string mission, int troops, int countries)
            {
                players.Add(new Player(mission, troops, countries));
            }

            public void RemovePlayer()
            {

            }
        

        public class Player
        {
            public Player(string mission, int troops, int countries)
            {
                Mission = mission;
                NumberOfTroops = troops;
                NumberOfCountries = countries;
            }

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
            foreach(var player in )
        }
    }
}
