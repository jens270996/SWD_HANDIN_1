using System;

namespace MementoLib
{
    public class GameMemento : IMemento
    {
        
        public IMementoState MementoState { get { return MementoState; } set { } }

        public GameMemento(GameMementoState state)
        {
            
            MementoState = state;
        }

        
    }
}
