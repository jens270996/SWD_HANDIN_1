using System;

namespace MementoLib
{
    public class GameMemento : IMemento
    {
        public GameMementoState gameState { get; private set; }
        
        public GameMemento(Game gameOriginator, GameMementoState state)
        {
            
            gameState = state;
        }

        public IMemento Restore()
        {
            return this;
        }
    }
}
