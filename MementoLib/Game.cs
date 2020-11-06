using System;
using System.Collections.Generic;
using System.Text;

namespace MementoLib
{
    public class Game : IOriginator
    {
        public void PrintPlayers()
        {
            foreach (var player in players)
            {
                player.Print();

            }
        }

        public void AlterTroops(int playerno, int changeintroops)
        {
            if(playerno<=players.Count)
                players[playerno - 1].NumberOfTroops += changeintroops;
        }

        public void AlterCountries(int playerno, int changeinCountries)
        {
            if (playerno <= players.Count)
                players[playerno - 1].NumberOfCountries += changeinCountries;
        }





        private List<Player> players;

            public void AddPlayer(string name, string mission, int troops, int countries)
            {
                players.Add(new Player(name, mission, troops, countries));
            }

            public void RemovePlayer(string name)
            {
                players.RemoveAll(Player => Player.PlayerName == name);
            }
        

        public class Player:ICloneable
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
            public int NumberOfTroops { get; set; }
            public int NumberOfCountries { get; set; }

            public void Print()
            {
                Console.WriteLine(PlayerName);
                Console.WriteLine("Du har missionen " + Mission + ".");
                Console.WriteLine("Dit antal tropper er " + NumberOfTroops + ".");
                Console.WriteLine("Du har " + NumberOfTroops + " lande at placerer dine tropper på.");
                Console.WriteLine("---------------------------------");
            }

            public object Clone()
            {
                return new Player(this.PlayerName, this.Mission, this.NumberOfTroops, this.NumberOfCountries);
            }
        }

        public MementoLib.IMemento Save()
        {
            var gamestate=new GameMementoState();
            foreach(var player in players)
            {
                gamestate.Players.Add(player.Clone() as Player);
            }

            return new GameMemento(gamestate);

        }

        public void RestoreState(IMemento memento)
        {
            players.Clear();
            var state=memento.MementoState as GameMementoState;
            foreach(var player in state.Players)
            {
                players.Add(player.Clone() as Player);
            }
        }

        public void ShowPlayers()
        {
            foreach (var item in players)
            {
                Console.WriteLine(item.PlayerName);
            }
        }
    }
}
