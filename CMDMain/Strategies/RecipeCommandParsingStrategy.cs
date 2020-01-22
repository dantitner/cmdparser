using CMDMain.Command;
using CMDMain.Exceptions;
using CMDMain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMDMain.Strategies
{
    class RecipeCommandParsingStrategy : ICommandParsingStrategy
    {
        private readonly Dictionary<string, IGameCommand> _variations;

        public RecipeCommandParsingStrategy()
        {
            _variations = new Dictionary<string, IGameCommand>();
            _variations.Add("buy",new RecipeBuyCommand());
            //todo find or smthg
        }
        public IGameCommand Parse(string input)
        {
            string[] args = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            IGameCommand command;

            if (!_variations.TryGetValue(args[0], out command))
                throw new ParsingException("There are no command like this.");

            command.args.Add(args[1]);

            return command;

        }
    }
}
