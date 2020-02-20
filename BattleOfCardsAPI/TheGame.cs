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
        public List<Card> GetChoosenCards(List<Player> playerList)
        {
            List<Card> ToShowOneRoundCards = new List<Card>(); 
            foreach (Player player in playerList)
            {
                ChoosenCards.Add(player.Hand[0]);
                ToShowOneRoundCards.Add(player.Hand[0]);
            }
            return ToShowOneRoundCards;
        }
        public Player LastRoundWinner(List<Player> playerList)
        {
            if (playerList.Count > 0)
            {
                foreach (Player player in playerList)
                {
                    if (player.Iswinner == true)
                    {
                        return player;
                    }


                }
                
            }
            throw new NullReferenceException("there is no such player");
        }
        
        public void OneRound(List<Player> playerList,int round)
        {
            Player startingPlayer;
            if(round > 0)
            {
                startingPlayer = LastRoundWinner(playerList);
            }
            else 
            {
                startingPlayer = playerList[0];
            }
            
            IComparer<Card> comparer;
            string answer = Convert.ToString(startingPlayer.ChooseAttribute()).ToLower();
            if (answer == "coding")
            {
                comparer = new Comparer.SortCodingDescending();
            }
     
            else if (answer == "gaming")
            {
                comparer = new Comparer.SortGamingDescending();
            }
            
            else if (answer == "softskills")
            {
                comparer = new Comparer.SortSoftSkillDescending();
            }
            else 
            {
                comparer = new Comparer.SortCoffeeConsuptionAscending();
            }
            

            ChoosenCards.Sort(comparer);
            if (comparer.Compare(ChoosenCards[0], ChoosenCards[1]) == 0  )
            {
                if(round == 0)
                {
                    startingPlayer.Iswinner = true;
                }
                foreach (Card card in ChoosenCards)
                {
                    DrawRound.Add(card);
                    
                }
                foreach (Player player in playerList)
                {
                    player.Hand.RemoveAt(0);
                }
                ChoosenCards.Clear();
                return;
            }

            

        

            if(ChoosenCards.Count > 0 && DrawRound.Count > 0)
            {
                foreach(Player player in playerList)
                {
                    if (player.Hand.Contains(ChoosenCards[0]))
                    {
                        player.Iswinner = true;
                        player.Hand.AddRange(ChoosenCards);
                        player.Hand.AddRange(DrawRound);
                        DrawRound.Clear();


                    }
                    else
                        player.Iswinner = false;
                    player.Hand.RemoveAt(0);


                }
                ChoosenCards.Clear();
            }
            else if (ChoosenCards.Count > 0 && DrawRound.Count == 0)
            {
                foreach (Player player in playerList)
                {
                    if (player.Hand.Contains(ChoosenCards[0]))
                    {
                        player.Iswinner = true;
                        player.Hand.AddRange(ChoosenCards);

                    }
                    else
                        player.Iswinner = false;
                    player.Hand.RemoveAt(0);
                }
                ChoosenCards.Clear();
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
