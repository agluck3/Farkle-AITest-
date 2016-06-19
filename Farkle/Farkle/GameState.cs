using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farkle
{
    class GameState
    {
        //Game state holds the complete state of a game at a moment.

        List<int> diceValues = new List<int>();
        List<int> diceToKeep = new List<int>();
        Player player = new Player();
        Player bot = new Player();
        FarkleScoring farkleScoring = new FarkleScoring();
        //Random with a very strong seed. :3
        Random uRand = new Random(System.DateTime.Now.Millisecond);
        public int numberOfDice = 6;

        
        public GameState(string name)
        {            
            player.accumulatedTotal = 0;
            bot.accumulatedTotal = 0;
            player.runningTotal = 0;
            bot.runningTotal = 0;
            player.isWinner = false;
            bot.isWinner = false;
            player.name = name;
            bot.name = "Bob";
            //Randomly choose who goes first
            chooseFirstPlayer();
            
        }
        public void roll() 
        {
            if (diceValues.Count <= 6)
            {
                int rollVal = numberOfDice - diceToKeep.Count;
                animateRoll();
                for (int i = 0; i <= rollVal; i++)
                {
                    diceValues.Add(uRand.Next(1, 6));
                }
                
                sortList();
                printBoard();
            }

            reviewDice();
            
        }

        public void notRoll()
        {
            if(player.turnState)
            {
                if(player.runningTotal > 500)
                {
                    player.turnState = false;
                    bot.turnState = true;
                }
            }
            else
            {
                Console.WriteLine("You do not have 500 points yet");
            }
            if (bot.turnState)
            {
                if (bot.runningTotal > 500)
                {
                    bot.turnState = false;
                    player.turnState = true;
                }
                
            }
        }
        
        public void reviewDice()
        {
        }
        public void sortList()
        {
            //Bubble sort
            if (diceValues.Count > 0)
            {
                for(int i = 0; i < diceValues.Count;i++)
                {
                    for(int j = i+1; j<diceValues.Count; j++)
                    {
                        if (diceValues[i] > diceValues[j])
                        {
                            int temp = diceValues[i];
                            diceValues[i] = diceValues[j];
                            diceValues[j] = temp;
                        }
                    }
                }
            }
        }

        public void chooseFirstPlayer()
        {
            int one = uRand.Next(1, 6);
            int two = uRand.Next(1, 6);
            if (one > two)
                player.turnState = true;
            else
                bot.turnState = true;
           
        }
        public bool isTerminalState()
        {
            if(isWinState())
            {
                if(player.isWinner == true)
                {
                    //player Won 
                    return true;       
                }
                else
                {
                    //Bob Won
                    return true;
                }
            }
            return false;
        }
        public bool isWinState()
        {
            if (player.accumulatedTotal >= 10000)
                return player.isWinner = true;
            else if (bot.accumulatedTotal >= 10000)
                return bot.isWinner = true;

            return false;
        }
        public void inputMove()
        {
            Console.WriteLine("Enter 1 to roll or 2 to not roll");
            try
            {
                int choice = int.Parse(Console.ReadLine());
                if(choice == 2)
                {
                    notRoll();
                }
                else if(choice == 1)
                {

                }

            }
            catch(FormatException fe) { Console.WriteLine(fe.Message); }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
        }
        public void animateRoll()
        {
            return;
        }
        public void printBoard()
        {
            Console.WriteLine(@"
___________________________________________________________________________
|                   ####  ##   ####  #  #  #     #####                    |
|                   #    #  #  #  #  # #   #     #                        |
|                   ##   ####  ####  ##    #     ###                      |
|                   #    #  #  # #   # #   #     #                        |
|                   #    #  #  #  #  #  #  ####  #####                    |
|_________________________________________________________________________|
");
        }
    }
}