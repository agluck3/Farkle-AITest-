﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farkle
{
    class Player
    {
        public string name { get; set; }
        public int accumulatedTotal { get; set; }
        public int runningTotal { get; set; }
        public bool turnState { get; set; }
        public bool isWinner { get; set; }
    }
}
