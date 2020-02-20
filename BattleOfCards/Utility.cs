using BattleOfCardsAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class Utility
    {
        List<Player> playerList;
        Deck deck;
        TheGame theGame;
        public Utility()
        {
            playerList = new List<Player>();
            deck = new Deck();            
        }

        public void GetPlayers()
        {
            Console.Write("How many players would you like? ");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.Write("Whats your username? ");
                string username = Console.ReadLine();
                ConsoleHumanPlayer player = new ConsoleHumanPlayer(username);
                playerList.Add(player);

            }
            Console.Write("How many bots would you like? ");
            int numberOfBots = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfBots; i++)
            {
                string botName = $"Bot {i}";
                ComputerPlayer player = new ComputerPlayer(botName);
                playerList.Add(player);

            }

            Console.WriteLine("\nAll players set!");
        }
        public void ShowCards(List<Card> cards)
        {
            foreach(Card card in cards)
            {
                Console.WriteLine(card.ToString());
            }
        }

        public void Run()
        {
            GetPlayers();

            Console.WriteLine("\nShuffling deck...");
            theGame = new TheGame(deck);
            theGame.StartTheGame(playerList);
            Console.WriteLine("Deck shuffled!\n");

            int round = 0;
            while (!theGame.CheckLoser(playerList))
            {

                List<Card> OneRoundCard = theGame.GetChoosenCards(playerList);
                
                
                theGame.OneRound(playerList,round);
                ShowCards(OneRoundCard);
                foreach(Player player in playerList)
                {
                    Console.WriteLine($"{player.Name} You have {player.Hand.Count} Card(s)");
                }
                Player roundWinner = theGame.LastRoundWinner(playerList);
                Console.WriteLine($"You won { roundWinner.Name}!");
                round++;
            }
            Console.WriteLine(theGame.GetWinner(playerList).Name ); 
        }
    }
}
