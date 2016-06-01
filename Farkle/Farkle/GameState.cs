using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farkle
{ 
    class GameState
    {
        List<DiceState> diceStates = new List<DiceState>();
        Player player = new Player();
        Player bot = new Player();
        
        public GameState(string name)
        {            
            player.points = 0;
            bot.points = 0;
            player.isWinner = false;
            bot.isWinner = false;
            player.name = name;
            bot.name = "Bob";
            
        }
        public void initialRoll()
        {
            
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
