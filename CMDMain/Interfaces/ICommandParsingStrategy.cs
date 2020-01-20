using System;
using System.Collections.Generic;
using System.Text;

namespace CMDMain.Interfaces
{
    interface ICommandParsingStrategy
    {
        IGameCommand Parse(string input);
    }
}
