using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farkle
{
    class DiceState
    {
        int diceState = 0;

        public DiceState()
        {
            diceState = getRandomDiceNumber();
        }

        public int getRandomDiceNumber()
        {
            animateDiceRoll();
            Random rand = new Random(System.DateTime.Now.Millisecond);
            return rand.Next(1, 6);
        }
        public int getValue()
        {
            return diceState;
        }
        public void animateDiceRoll()
        {
            return;
        }
    }
}
