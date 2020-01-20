using System;
using System.Collections.Generic;
using System.Text;

namespace CMDMain.Interfaces
{
    interface IParsingStrategiesFactory
    {
        Dictionary<string, ICommandParsingStrategy> GetStrategies();
    }
}
