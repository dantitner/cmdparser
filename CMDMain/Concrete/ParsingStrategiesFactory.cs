using CMDMain.Interfaces;
using CMDMain.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMDMain.Concrete
{
    class ParsingStrategiesFactory : IParsingStrategiesFactory
    {
        public Dictionary<string, ICommandParsingStrategy> GetStrategies()
        {
            var strategies =  new Dictionary<string, ICommandParsingStrategy>();
            strategies.Add("wisper", new SayCommandParsingStrategy());
            strategies.Add("say", new SayCommandWOBrakeysParsingStrategy());
            strategies.Add("recipe", new RecipeCommandParsingStrategy());
            return strategies;
        }
    }
}
