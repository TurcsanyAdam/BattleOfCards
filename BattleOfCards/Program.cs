using System;
using System.Collections.Generic;
using BattleOfCardsAPI;

namespace BattleOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility utility = new Utility();
            List<Player> playerList = utility.GetPlayers();
            Deck deck = new Deck();

            deck.ShuffleAndDeal(playerList);
            utility.GetMenuInput();
        }

    }
}
