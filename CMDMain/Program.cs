using CMDMain.Concrete;
using System;

namespace CMDMain
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new GameContext();
            context.User.Money += 9000;
            var comandHandler = new CommandHandler(new ParsingStrategiesFactory());
            var command = comandHandler.Process("//recipe buy torch");
            command.Execute(context);
            Console.WriteLine(context.User.Money);
            Console.WriteLine(context.User.Recipes.Count);
        }
    }
}
