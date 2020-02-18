using System;
using System.Collections.Generic;
using BattleOfCardsAPI;

namespace BattleOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            List<Player> playerList = new List<Player>();
            Random rand = new Random();
            Console.Write("How many players would you like?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.Write("Whats your username?");
                string username = Console.ReadLine();
                HumanPlayer player = new HumanPlayer(username);
                playerList.Add(player);
                
            }
            Console.Write("How many bots would you like?");
            int numberOfBots = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfBots; i++)
            {
                string botName = $"Bot {i}";
                ComputerPlayer player = new ComputerPlayer(botName);
                playerList.Add(player);

            }

            int maxCards = deck.Cards.Count / playerList.Count;
            bool maxCardsReached = true;
            while (maxCardsReached)
            {
                foreach (Player player1 in playerList)
                {
                    if (player1.Hand.Count != maxCards)
                    {
                        int randomCard = rand.Next(0, deck.Cards.Count - 1);
                        player1.AddCardToTheHand(deck.Cards[randomCard]);
                        deck.Cards.RemoveAt(randomCard);
                    }
                    else
                    {
                        maxCardsReached = false;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
