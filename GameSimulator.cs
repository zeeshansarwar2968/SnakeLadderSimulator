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
        
        // Function to create the logic of the game
        public void GameLogic()
        {
            Console.WriteLine("The Starting Position of the Player is {0}",position);
        }
    }
}
