using System;

namespace MementoLib
{
    public class GameMemento : IMemento
    {
        private GameMementoState gameState { get; set; }
        private Game GameOriginator { get; set; }
        public GameMemento(Game gameOriginator, GameMementoState state)
        {
            GameOriginator = gameOriginator;
            gameState = state;
        }
        public void Restore()
        {
            GameOriginator.SetState(gameState);
        }
    }
}
