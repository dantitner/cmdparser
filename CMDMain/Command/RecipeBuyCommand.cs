using CMDMain.Concrete;
using CMDMain.Exceptions;
using CMDMain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using UserContext.Models;

namespace CMDMain.Command
{
    class RecipeBuyCommand : IGameCommand
    {
        private readonly Dictionary<string, int> _prices;
        public RecipeBuyCommand()
        {
            args = new List<string>();
            _prices = new Dictionary<string, int>();
            _prices.Add("torch",10);
        }

       
        public List<string> args { get; set; }

        public void Execute(GameContext context)
        {
            if (args.Count != 1)
                throw new CommandExecutionExeption("There are no valid recipe.");
            int price = 0;
            if (!_prices.TryGetValue(args[0], out price))
                throw new CommandExecutionExeption("There are no price for that.");
            if (context.User.Money < price)
                throw new CommandExecutionExeption("You don't have enought money.");
            context.User.Money -= price;
            Recipe recipeToAdd;
            if (!context.Recipes.TryGetValue(args[0], out recipeToAdd))
                throw new CommandExecutionExeption("There are no recipe for this keyword.");
            context.User.Recipes.Add(recipeToAdd);
        }
    }
}
