﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MementoLib
{
    public interface IOriginator
    {
        IMemento Save();
        void RestoreState(IMemento memento);
    }
}
