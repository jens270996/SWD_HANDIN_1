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

       
        public IMemento GetMementoAtIndex(int index)
        {
            
            return Mementos[index];
        } 
       

        public void AddMemento(IMemento memento)
        {
            Mementos.Add(memento);
        }
    }
}
