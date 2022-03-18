﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Interfaces
{
    public interface ICommand
    {
        void ExecuteAction();
        void UndoAction();
    }
}
