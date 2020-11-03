using System;
using System.Collections.Generic;
using System.Text;

namespace MementoLib
{
    public class GameMementoState:IMementoState
    {
        //string _oldState { get; set; }
        //int _player { get; set; }

        //public Game.Player GameObject;
        public GameMementoState()
        {
            Players = new List<Game.Player>();
        }
        public List<Game.Player> Players { get; set; }


    }
}
