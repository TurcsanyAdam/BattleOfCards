using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAPI
{
    public abstract class Player
    {
       public enum Attributes
        {
            Coding,
            Gaming,
            SoftSkills,
            CoffeeConsuption,

        }

        public string Name {  get; protected internal set; }
        public List<Card> Hand { get; protected internal set; }
        public bool Iswinner { get; protected internal set; }
       

        public Player(string Name)
        {
            this.Name = Name;
            Hand = new List<Card>();
            Iswinner = false;
           

        }

        public abstract Attributes ChooseAttribute();
        
        public void AddCardToTheHand(Card card)
        {
            Hand.Add(card);
        }

    }
}
