using System;

namespace MementoLib
{
    public class GameMemento : IMemento
    {
        public GameMemento(Game gameOriginator, GameMementoState state)
        {

        }
        public IMemento Restore()
        {
            throw new NotImplementedException();
        }
    }
}
