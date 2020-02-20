using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAPI
{
    public class TooManyPlayersException : Exception
    {
        public TooManyPlayersException():
            base("Too many players for this deck size! ")
        {

        }
    }
}
