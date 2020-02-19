using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAPI
{
    public class HumanPlayer : Player
    {
        
        public HumanPlayer(string Name) : base(Name)
        {
            
        }

        public override Attributes ChooseAttribute()
        {
           
            throw new NotImplementedException();
        }
    }
}
