using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderSimulator
{
    public class ExactWinningPosition
    {
        //Initialising a variable to hold the value of position of player on the board
        public int position = 0;
        public int diceCounter = 0;
        public string optionValue = "";

        //Initialising Random to for future application
        Random generateNum = new Random();


        // Function to create the logic of the game
        public void GameLogic()
        {
            Console.WriteLine("The Starting Position of the Player is {0}", position);

            //While loop to run through the iterations till the postion of 100 is reached

            while(position < 100)
            {
                // Using random method to generate a random number between 1 and 6
                int dieRoll = generateNum.Next(1, 7);
                Console.WriteLine("The rolled dice value is: {0}", dieRoll);
                diceCounter++;

                // Using random method to generate a random number between 1 and 4 to randomize the option selection
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
                        optionValue = "Snake";
                        break;
                    default:
                        break;
                }

                Console.WriteLine("The rolled option is: " + optionValue);


                //Logic to increment the position on the basis of option and diceRoll values and exit if fianl position reached
                if (optionValue == "Ladder")
                {
                    if ((position + dieRoll) > 100)
                    {
                        position = 100;

                    }else
                    {
                        position += dieRoll;
                    }
                }
                else if (optionValue == "Snake")
                {
                    if (position<0)
                    {
                        position = 0;
                    }else
                    {
                        position -= dieRoll;
                    }
                }
                else
                {
                    continue;
                }

                Console.WriteLine("Current Position of Player on the board is : " + position);
                Console.WriteLine("");

            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Final Position of the Player on the board is : " + position);
            Console.WriteLine("The count of dice rolls for the player to reach the winning position is : "+diceCounter);
        }


    }
}
