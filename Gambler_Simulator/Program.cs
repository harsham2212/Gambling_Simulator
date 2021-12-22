using System;

namespace Gambler_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambling Simulator Problem!\n");
            Game.Game_play();
            Game play = new Game();
            play.Win_loose();
        }
    }
}
