using CMDMain.Command;
using CMDMain.Exceptions;
using CMDMain.Interfaces;
using System.Linq;
using System.Text.RegularExpressions;

namespace CMDMain.Strategies
{
    class SayCommandParsingStrategy : ICommandParsingStrategy
    {
        Regex regex = new Regex(@"^<.*>$");

        public IGameCommand Parse(string input)
        {
            MatchCollection matches = regex.Matches(input);

            if (matches.Count != 1)
            {
                throw new ParsingException("Command should have only one argument.");
            }

            input = input.Substring(1, input.Length - 2);
            
            return new SayCommand() { Message = input};
        }
    }
}
