using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAPI
{
    class TheGame
    {
        public Deck deck;
        List<Card> Choo

        public TheGame(Deck deck)
        {
            this.deck = deck;
        }

        public void StartTheGame(List<Player> playerList)
        {
            deck.ShuffleAndDeal(playerList);
        }
        
        public void OneRound(string theChosenSpecification,List<Player> playerList)
        {

        }
       
    }
}
