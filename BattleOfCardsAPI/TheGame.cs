using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAPI
{
    public class TheGame
    {
        public Deck deck;
        public List<Card> ChoosenCards { get; private set; }
        public List<Card> DrawRound { get; private set; }
        

        public TheGame(Deck deck)
        {
            this.deck = deck;
            ChoosenCards = new List<Card>();
            DrawRound = new List<Card>();
            
        }

        public void StartTheGame(List<Player> playerList)
        {
            deck.ShuffleAndDeal(playerList);
        }

        public bool CheckLoser(List<Player> playerList)
        {
            foreach(Player player in playerList)
            {
                if(player.Hand.Count == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public Player GetWinner(List<Player> playerList)
        {
            int maxCards = 0;
            Player winner = null;
            foreach (Player player in playerList)
            {
                if (player.Hand.Count > maxCards)
                {
                    maxCards = player.Hand.Count;
                    winner = player;
                }
            }
            return winner;
        }
        
        public void OneRound(string theChosenSpecification,List<Player> playerList)
        {
            foreach(Player player in playerList)
            {
                ChoosenCards.Add(player.Hand[0]);
            }
            if(theChosenSpecification ==  "1")
            {
                ChoosenCards.Sort(new Comparer.SortCodingDescending());
                if(ChoosenCards[0].Coding == ChoosenCards[1].Coding)
                {
                    foreach(Card card in ChoosenCards)
                    {
                        DrawRound.Add(card);
                    }
                    ChoosenCards.Clear();
                }

            }
            else if (theChosenSpecification == "2")
            {
                ChoosenCards.Sort(new Comparer.SortGamingDescending());
                if (ChoosenCards[0].Gaming == ChoosenCards[1].Gaming)
                {
                    foreach (Card card in ChoosenCards)
                    {
                        DrawRound.Add(card);
                    }
                    ChoosenCards.Clear();
                }
            }
            else if (theChosenSpecification == "3")
            {
                ChoosenCards.Sort(new Comparer.SortSoftSkillDescending());
                if (ChoosenCards[0].Gaming == ChoosenCards[1].Gaming)
                {
                    foreach (Card card in ChoosenCards)
                    {
                        DrawRound.Add(card);
                    }
                    ChoosenCards.Clear();
                }
            }
            else if (theChosenSpecification == "4")
            {
                ChoosenCards.Sort(new Comparer.SortCoffeeConsuptionAscending());
                if (ChoosenCards[0].Gaming == ChoosenCards[1].Gaming)
                {
                    foreach (Card card in ChoosenCards)
                    {
                        DrawRound.Add(card);
                    }
                    ChoosenCards.Clear();
                    
                }
            }
            if(ChoosenCards.Count > 0 && DrawRound.Count > 0)
            {
                foreach(Player player in playerList)
                {
                    if (player.Hand.Contains(ChoosenCards[0]))
                    {
                        player.Hand.AddRange(ChoosenCards);
                        player.Hand.AddRange(DrawRound);
                        DrawRound.Clear();
                        

                    }
                    player.Hand.RemoveAt(0);


                }
            }
            else if (ChoosenCards.Count > 0 && DrawRound.Count == 0)
            {
                foreach (Player player in playerList)
                {
                    if (player.Hand.Contains(ChoosenCards[0]))
                    {
                        player.Hand.AddRange(ChoosenCards);

                    }
                    player.Hand.RemoveAt(0);
                }
            }
            else if(ChoosenCards.Count == 0 && DrawRound.Count > 0)
            {
                foreach (Player player in playerList)
                {
                    player.Hand.RemoveAt(0);
                }
            }
            
        }

    }
}
