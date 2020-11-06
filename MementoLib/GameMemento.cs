using System;

namespace MementoLib
{
    public class GameMemento : IMemento
    {

        public IMementoState MementoState { get; set; }
        
        
        public GameMemento(GameMementoState state)
        {
            
            MementoState = state;
        }

        
    }
}
