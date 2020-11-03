using System;
using System.Collections.Generic;
using System.Text;

namespace MementoLib
{
    public class MementoCaretaker
    {
        public MementoCaretaker()
        {
            Mementos = new List<IMemento>();
        }
        private List<IMemento> Mementos { get; set; }

        public void RollBackToIndex(int index)
        {
            Mementos[index].Restore();
        }
        public IMemento GetMementoAtIndex(int index)
        {
            return Mementos[index];
        }

        public void RollBackToLatest()
        {
            Mementos[Mementos.Count - 1].Restore();
        }

        public void AddMemento(IMemento memento)
        {
            Mementos.Add(memento);
        }
    }
}
