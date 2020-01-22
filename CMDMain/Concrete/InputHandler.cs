using CMDMain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMDMain.Concrete
{
    class CommandHandler : ICommandHandler
    {
        private readonly Dictionary<string, ICommandParsingStrategy> _strategies;

        public CommandHandler(IParsingStrategiesFactory factory)
        {
            _strategies = factory.GetStrategies();
        }

        public IGameCommand Process(string message)
        {
            if (message.StartsWith("//"))
            {
                message = message.Remove(0, 2);
                var command = message.Substring(0, message.IndexOf(" "));
                var arguments = message.Replace(command, "");
                arguments = arguments.Trim();
                ICommandParsingStrategy parsingStrategy;
                if (!_strategies.TryGetValue(command, out parsingStrategy))
                    Console.WriteLine("Command not found.");
                return parsingStrategy.Parse(arguments);

            }
            else
                throw new Exception("Not a command");
        }

    }
}
