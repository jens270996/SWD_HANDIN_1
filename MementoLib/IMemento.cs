using System;
using System.Collections.Generic;
using System.Text;

namespace MementoLib
{
    public interface IMemento
    {
        
        IMemento Restore();
    }
}
