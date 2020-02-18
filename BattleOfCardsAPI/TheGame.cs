using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAPI
{
    class TheGame
    {
        public Deck deck;
        public List<Card> ChoosenCards { get; private set; }
        

        public TheGame(Deck deck, Comparer Comparer)
        {
            this.deck = deck;
            ChoosenCards = new List<Card>();
            
        }

        public void StartTheGame(List<Player> playerList)
        {
            deck.ShuffleAndDeal(playerList);
        }
        
        public void OneRound(string theChosenSpecification,List<Player> playerList)
        {
            foreach(Player player in playerList)
            {
                ChoosenCards.Add(player.Hand[0]);
            }
            if(theChosenSpecification ==  "1")
            {
                ChoosenCards.Sort(SortCodingDescending)
            }
        }
       
    }
}
