﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MementoLib
{
    public interface IMemento
    {

        public IMementoState MementoState { get; set; }
    }
}
