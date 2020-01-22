using CMDMain.Concrete;
using CMDMain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using UserContext.Models;

namespace CMDMain.Command
{
    class SayCommand : IGameCommand
    {
        public string Message { get; set; }
        public List<string> args { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Execute(GameContext context)
        {
            Console.WriteLine($"{context.User.UserName} says: {Message}");
        }
    }
}
