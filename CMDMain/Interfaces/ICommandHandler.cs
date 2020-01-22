using System;
using System.Collections.Generic;
using System.Text;

namespace CMDMain.Interfaces
{
    interface ICommandHandler
    {
        IGameCommand Process(string message);
    }
}
