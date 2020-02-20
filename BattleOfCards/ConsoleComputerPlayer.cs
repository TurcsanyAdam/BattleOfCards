using System;
using System.Collections.Generic;
using System.Text;
using BattleOfCardsAPI;
using System.Threading;

namespace BattleOfCards
{
    class ConsoleComputerPlayer : Player
    {
        Random rng;
        public ConsoleComputerPlayer(string Name) : base(Name)
        {
            rng = new Random();
        }

        public override Attributes ChooseAttribute()
        {
            Dictionary<int, string> botMenu = new Dictionary<int, string>() { { 1, "Coding"},
                                                                              { 2, "Gaming"},
                                                                              { 3, "SoftSkills" },
                                                                              { 4, "CoffeeConsuption"} };
            int randomMenu = rng.Next(1, botMenu.Count - 1);

            Thread.Sleep(1000);
            Console.WriteLine($"The bot({Name}),choosen the {botMenu[randomMenu]}");
            Console.WriteLine($"The bot({Name})'s first card is {Hand[0].ToString()}");
            Thread.Sleep(2000);
            Attributes answer = (Attributes)Enum.Parse(typeof(Attributes), botMenu[randomMenu], true);
           
            return answer;
        }
    }
}
