using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAPI
{
    class HumanPlayer : Player
    {
        
        public HumanPlayer(string Name) : base(Name)
        {
            
        }

        public override string ChooseTheSpecification()
        {
            return "return";
        }

    }
}
