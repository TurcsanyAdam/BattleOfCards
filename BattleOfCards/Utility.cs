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

        public string GetMenuInput()
        {
            string menu = $"Please choose from the below specifications!\n" +
                            "1. Coding skills\n" +
                            "2. Gaming skills\n" +
                            "3. Soft skills\n" +
                            "4. Coffee consumption";

            Console.WriteLine(menu);
            string result = Console.ReadLine();
            switch (result)
            {
                case "1":
                    Console.WriteLine("Chosen stat is \"Coding Skills\"");
                    break;
                case "2":
                    Console.WriteLine("Chosen stat is \"Gaming Skills\"");
                    break;
                case "3":
                    Console.WriteLine("Chosen stat is \"Soft Skills\"");
                    break;
                case "4":
                    Console.WriteLine("Chosen stat is \"Coffee consumptio\"");
                    break;
            }
            return result;

        }

        public void GetPlayers()
        {
            Console.Write("How many players would you like? ");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.Write("Whats your username? ");
                string username = Console.ReadLine();
                HumanPlayer player = new HumanPlayer(username);
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
        }


        public void Run()
        {
            GetPlayers();
            theGame = new TheGame(deck);
            theGame.StartTheGame(playerList);
            while (!theGame.CheckLoser(playerList))
            {

                theGame.GetChoosenCards(playerList);
                foreach(Card card in theGame.ChoosenCards)
                {
                    Console.WriteLine(card.ToString());
                }
                Player player;
                player.ChooseAttribute();
                theGame.OneRound(GetMenuInput(), playerList);
            }
            Console.WriteLine(theGame.GetWinner(playerList).Name ); 
        }
    }
}
