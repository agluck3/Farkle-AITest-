using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farkle
{
    class FarkleScoring
    {
        //Handle 6 Dice
        List <DiceState> diceStates = new List<DiceState>();

        public FarkleScoring(List<DiceState> dStates)
        {
            for(int i = 0; i < dStates.Count; i++)
            {
                diceStates[i] = dStates[i];
            }
        }
        public void checkDice()
        {
            foreach(DiceState ds in diceStates)
            {

            }
        }
    }
}
