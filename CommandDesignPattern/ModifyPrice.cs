using CommandDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
     class ModifyPrice
    {
            private readonly List _commands;
            private ICommand _command;

            public ModifyPrice()
            {
                _commands = new List();
            }

            public void SetCommand(ICommand command) => _command = command;

            public void Invoke()
            {
                _commands.Add(_command);
                _command.ExecuteAction();
            }

            public void UndoActions()
            {
                foreach (var command in Enumerable.Reverse(_commands))
                {
                    command.UndoAction();
                }
            }
        }
    }
}
