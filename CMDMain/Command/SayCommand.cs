using CMDMain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMDMain.Command
{
    public class SayCommand : IGameCommand
    {
        public string Message { get; set; }

        public void Execute()
        {
            Console.WriteLine(Message);
        }
    }
}
