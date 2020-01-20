using CMDMain.Concrete;
using System;

namespace CMDMain
{
    class Program
    {
        static void Main(string[] args)
        {

            new InputHandler(new ParsingStrategiesFactory()).Process("//say <message splited>");
        }
    }
}
