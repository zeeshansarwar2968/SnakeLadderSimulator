using System;

namespace SnakeLadderSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder Game Simulator");

            GameSimulator simulator = new GameSimulator();

            ExactWinningPosition exactWinningPosition = new ExactWinningPosition(); 

            TwoPlayerSimulator twoPlayer = new TwoPlayerSimulator();

            Console.WriteLine("");
            //simulator.GameLogic();
            //exactWinningPosition.GameLogic();
            twoPlayer.GameLogic();
            Console.ReadKey();
        }
    }
}
