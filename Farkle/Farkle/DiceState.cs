﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farkle
{
    class DiceState
    {
        public DiceState()
        {

        }

        public int getRandomDiceNumber()
        {
            animateDiceRoll();
            Random rand = new Random(System.DateTime.Now.Millisecond);
            return rand.Next(1, 6);
        }
        public void animateDiceRoll()
        {
            return;
        }
    }
}