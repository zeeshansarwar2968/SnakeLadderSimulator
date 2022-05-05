using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderSimulator
{
    internal class GameSimulator
    {
        //Initialising a variable to hold the value of position of player on the board
        int position = 0;

        // Using random method to generate a random number between 1 and 6
        Random generateNum = new Random();

        
        
        // Function to create the logic of the game
        public void GameLogic()
        {
            // Using random method to generate a random number between 1 and 6
            int dieRoll = generateNum.Next(1, 7);
            Console.WriteLine("The Starting Position of the Player is {0}",position);
            Console.WriteLine("The value of the die roll is {0}", dieRoll);

        }
    }
}
                                       