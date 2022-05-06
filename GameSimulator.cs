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

        string optionValue="";
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
            Console.WriteLine("The Starting Position of the Player is {0}", position);

            //While loop to run through the iterations till the postion of 100 is reached
            
            while(position<100)
            {
                // Using random method to generate a random number between 1 and 6
                int dieRoll = generateNum.Next(1, 7);
                Console.WriteLine("The rolled die value is: {0}",dieRoll);

                // Using random method to generate a random number between 1 and 4
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

                Console.WriteLine("The rolled option is: "+optionValue);

                if (position >= 0)
                {
                    if (optionValue == "No Play")
                    {
                        continue;
                    }
                    else if (optionValue == "Ladder")
                    {
                        position = position + dieRoll;
                    }
                    else
                    {
                        position = position - dieRoll;
                    }

                }else if(position < 0)
                {
                    //Console.WriteLine("Not Valid, revert position to 0");
                    position = 0;
                    continue;
                }
                Console.Write("The running Position is : ");
                Console.WriteLine(position);
                Console.WriteLine("");


            }

            Console.WriteLine("");
            //Console.WriteLine("Final position is {0}", position);
            Console.WriteLine("");
            Console.WriteLine("The player has reached the winning position");
        }


    }
}
                                       