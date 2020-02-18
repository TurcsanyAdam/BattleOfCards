using System;
using System.Collections.Generic;
using System.Text;


namespace BattleOfCardsAPI
{
    public class Deck
    {
        public List<Card> Cards { get; private set; }
        private Random rng; 
        public Deck()
        {
            rng = new Random();
            Initializer initializer = new Initializer();
            Cards = initializer.DeserializerCards();
        }

        public  void ShuffleAndDeal(List<Player> playerList)
        {
            int maxCards = Cards.Count / playerList.Count;
            bool maxCardsReached = true;
            while (maxCardsReached)
            {
                foreach (Player player1 in playerList)
                {
                    if (player1.Hand.Count != maxCards)
                    {
                        int randomCard = rng.Next(0, Cards.Count - 1);
                        player1.AddCardToTheHand(Cards[randomCard]);
                        Cards.RemoveAt(randomCard);
                    }
                    else
                    {
                        maxCardsReached = false;
                    }
                }
            }
        }
    }
}
