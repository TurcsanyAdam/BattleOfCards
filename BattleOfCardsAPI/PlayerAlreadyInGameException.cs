using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAPI
{
    public class PlayerAlreadyInGameException : Exception
    {
        public PlayerAlreadyInGameException() :
            base("Player with this username already in game! ")
        {

        }
    }
}
