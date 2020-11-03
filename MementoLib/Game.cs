using System;
using System.Collections.Generic;
using System.Text;

namespace MementoLib
{
    public class Game:IOriginator
    {
        public class GameMemento
        {
        }

        public class GameObject
        {
            private List<Player> players;

            public void AddPlayer(string mission, int troops, int countries)
            {
                players.Add(new Player(mission, troops, countries));
            }

            public void RemovePlayer()
            {

            }
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

        }

        public void RestoreState(IMemento memento)
        {
            throw new NotImplementedException();
        }
    }
}
