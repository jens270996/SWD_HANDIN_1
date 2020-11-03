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
    }
}
