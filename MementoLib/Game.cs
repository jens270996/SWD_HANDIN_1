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

            public void AddPlayer(string name, string mission, int troops, int countries)
            {
                players.Add(new Player(name, mission, troops, countries));
            }

            public void RemovePlayer(string name)
            {
                players.Remove(name);
            }
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

            private string PlayerName;
            private string Mission;
            private int NumberOfTroops;
            private int NumberOfCountries;
        }

        public MementoLib.IMemento Save()
        {
            throw new NotImplementedException();
        }

        public void RestoreState(IMemento memento)
        {
            throw new NotImplementedException();
        }
    }
}
