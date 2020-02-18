using BattleOfCardsAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCards
{
    public class Utility
    {
        public int GetMenuInput()
        {
            Console.Clear();
            string menu = $"Please choose from the below specifications!\n" +
                            "1. Coding skills\n" +
                            "2. Gaming skills\n" +
                            "3. Soft skills\n" +
                            "4. Coffee consumption";

            Console.WriteLine(menu);
            int result = int.Parse(Console.ReadLine());
            return result;

        }

        public List<Player> GetPlayers()
        {
            List<Player> playerList = new List<Player>();

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
            return playerList;
        }
    }
}
