using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAPI
{
    class Deck
    {
       public List<Card> Cards { get; set; }

        public Deck()
        {
            Initializer initializer = new Initializer();
            Cards = initializer.DeserializerCards();
        }

        public void Shuffle()
        {

        }
    }
}
