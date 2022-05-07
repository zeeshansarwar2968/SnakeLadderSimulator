using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderSimulator
{
    public class TwoPlayerSimulator
    {
        //Initialising a variable to hold the value of position of player on the board
        public int[] playerPosition = { 0, 0 };
        public int[] playerDiceCounter = { 0 , 0 };
        public string[] optionValue = { "noPlay" , "Ladder" , "Snake" };
        public int winner;

        //Initialising Random to for future application
        Random generateNum = new Random();


        // Function to create the logic of the game
        public void GameLogic()
        {
            Console.WriteLine("The Starting Position of the Player is {0}");

            int playerTurn = 0;
            //While loop to run through the iterations till the postion of 100 is reached

            while (playerPosition[0] < 100 && playerPosition[1] < 100)
            {
                // Using random method to generate a random number between 1 and 6
                int dieRoll = generateNum.Next(1, 7);
                Console.WriteLine("The rolled dice value is: {0}", dieRoll);

                playerDiceCounter[playerTurn]++;

                // Using random method to generate a random number between 0 and 3 according to the length of the option array to randomize the option selection in the array
                int optionIndex = generateNum.Next(optionValue.Length);
                Console.WriteLine("The Player has received option : "+optionValue[optionIndex]);
                            
                //Logic to skip the turn and loop due to selection of noPlay option
                if (optionValue[optionIndex] == "noPlay" && playerTurn == 0)
                {
                    playerTurn = 1;
                    continue;
                } else if (optionValue[optionIndex] == "noPlay" && playerTurn == 1)
                {
                    playerTurn = 0;
                    continue;
                }

                //Logic to increment the position on the basis of option and diceRoll values and exit if final position of 100 is reached
                if (optionValue[optionIndex] == "Ladder")
                {
                    if (playerPosition[playerTurn] + dieRoll > 100)
                    {
                        playerPosition[playerTurn] = 100;
                        winner = playerTurn;
                        break;
                    }
                    else
                    {
                        playerPosition[playerTurn] += dieRoll;
                        continue;
                    }
                }
                else if (optionValue[optionIndex] == "Snake")
                {
                    if (playerPosition[playerTurn] < dieRoll)
                    {
                        playerPosition[playerTurn] = 0;
                    }
                    else
                    {
                        playerPosition[playerTurn] -= dieRoll;
                    }
                }


                //Logic for a check of player position for controlled exit of the while loop
                if (playerPosition[0] == 100 || playerPosition[1] == 100)
                {
                    winner = playerTurn;
                    break;
                }

                //Logic to alternate the turns between the two players
                if (playerTurn == 0)
                {
                    playerTurn = 1;
                }
                else
                {
                    playerTurn = 0;
                }
               

            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("The winner of the game is : Player{0}",winner+1 );
            Console.WriteLine("The Position of winner of the game on the board is : {0}", playerPosition[winner]);
            Console.WriteLine("Player1 Position  : " + playerPosition[0]);
            Console.WriteLine("Player2 Position : " + playerPosition[1]);


        }


    }
}
