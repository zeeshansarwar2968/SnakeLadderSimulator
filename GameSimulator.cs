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

        string optionValue;
        //Initialising Random to for future application
        Random generateNum = new Random();
        
        
        
        public void OptionCheck()
        {
            // Using random method to generate a random number between 1 and 3
            int options = generateNum.Next(1, 4);
            switch (options)
            {
                case 1:
                    optionValue = "No Play";
                    break;
                case 2:
                    optionValue = "Ladder";
                    break;
                case 3:
                    optionValue= "Snake";
                    break;
                default:
                    break;
            }

        }


        // Function to create the logic of the game
        public void GameLogic()
        {
            // Using random method to generate a random number between 1 and 6
            int dieRoll = generateNum.Next(1, 7);
            Console.WriteLine("The Starting Position of the Player is {0}", position);
            Console.WriteLine("The value of the die roll is {0}", dieRoll);
            //Console.WriteLine("The option selected : {0}", optionValue);
            Console.WriteLine("");

            //Conditional statment to increase position of player on option check
            if(optionValue == "No Play")
            {
                Console.WriteLine("No Play Option rolled. Skip this turn");
            }else if (optionValue == "Ladder")
            {
                Console.WriteLine("Ladder Option rolled. Move Forward");
                position = position + dieRoll;
                Console.WriteLine("New position is {0}", position);
            }
            else
            {
                Console.WriteLine("Snake Option rolled. Move Backwards");
                position = position - dieRoll;
                Console.WriteLine("New position is {0}", position);
            }


        }

    }
}
                                       