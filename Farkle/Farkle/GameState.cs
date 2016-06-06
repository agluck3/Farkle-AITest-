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
        Player player = new Player();
        Player bot = new Player();
        //Random with a very strong seed. :3
        Random uRand = new Random(System.DateTime.Now.Millisecond);
        
        public GameState(string name)
        {            
            player.points = 0;
            bot.points = 0;
            player.isWinner = false;
            bot.isWinner = false;
            player.name = name;
            bot.name = "Bob";
            
        }
        public int roll()
        {
            return uRand.Next(1, 6);
        }
        public void sortList()
        {

            if(diceValues.Count > 0)
            {
                foreach(int val in diceValues)
                {

                }
            }
        }
        public bool isTerminalState()
        {
            if(isWinState())
            {
                if(player.isWinner == true)
                {
                    //player Won        
                }
                else
                {
                    //Bob Won
                }
            }
            return false;
        }
        public bool isWinState()
        {
            if (player.points >= 10000)
                return player.isWinner = true;
            else if (bot.points >= 10000)
                return bot.isWinner = true;

            return false;
        }
    }
}
