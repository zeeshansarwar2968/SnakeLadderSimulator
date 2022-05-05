using System;

namespace SnakeLadderSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder Game Simulator");

            GameSimulator simulator = new GameSimulator();
            Console.WriteLine("");
            simulator.OptionCheck();
            simulator.GameLogic();
            Console.ReadKey();
        }
    }
}
