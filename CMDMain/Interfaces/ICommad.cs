using CMDMain.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMDMain.Interfaces
{
    interface IGameCommand
    {
        List<string> args { get; set; }
        void Execute(GameContext context);
    }
}
