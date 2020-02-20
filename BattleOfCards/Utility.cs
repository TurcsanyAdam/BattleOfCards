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

                theGame.GetChoosenCards(playerList);
                
                
                theGame.OneRound(playerList,round);
                round++;
            }
            Console.WriteLine(theGame.GetWinner(playerList).Name ); 
        }
    }
}
