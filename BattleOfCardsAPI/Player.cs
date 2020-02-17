using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAPI
{
    abstract class Player
    {
        public string Name { get; protected set; }
        public List<Card> Hand { get; private set; }
        public int RoundWins { get; protected set; }

        public Player(string Name)
        {
            this.Name = Name;
            Hand = new List<Card>();
            RoundWins = 0;

        }
        public abstract string ChooseTheSpecification();
        
        public void AddCardToTheHand(Card card)
        {
            Hand.Add(card);
        }

    }
}
