﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farkle
{
    class DiceState
    {
        private int diceState = 0;

        public DiceState()
        {
        }

        public int rollDice()
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
