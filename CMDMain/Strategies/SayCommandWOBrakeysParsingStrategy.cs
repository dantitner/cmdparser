using CMDMain.Command;
using CMDMain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMDMain.Strategies
{
    class SayCommandWOBrakeysParsingStrategy : ICommandParsingStrategy
    {
        public IGameCommand Parse(string input)
        {
            return new SayCommand() { Message = input };
        }
    }
}
