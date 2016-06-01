using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farkle
{ 
    class GameState
    {
        DiceState[] diceStates;
        Player player = new Player();
        Player bot = new Player();
        
        public GameState()
        {            
            player.points = 0;
            bot.points = 0;
        }
        public bool isTerminalState()
        {
            if(isWinState())
            {
                return true;
            }
            return false;
        }
        public bool isWinState()
        {

        }
    }
}
