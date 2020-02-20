﻿using BattleOfCardsAPI;
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
                ConsoleComputerPlayer player = new ConsoleComputerPlayer(botName);
                playerList.Add(player);

            }

            Console.WriteLine("\nAll players set!");
        }
        public void ShowCards(List<Card> cards,List<Player> playerList)
        {
            for(int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine($"{playerList[i].Name}'s card : {cards[i].ToString()}");
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
                ShowCards(OneRoundCard,playerList);
                
                Player roundWinner = theGame.LastRoundWinner(playerList);
                
                Console.WriteLine($"You won { roundWinner.Name}!");
                Console.WriteLine();
                foreach (Player player in playerList)
                {
                    Console.WriteLine($"{player.Name} You have {player.Hand.Count} Card(s)");
                }
                Console.WriteLine();
                round++;
                
            }
            Console.WriteLine();
            Console.WriteLine(theGame.GetWinner(playerList).Name ); 
        }
    }
}
