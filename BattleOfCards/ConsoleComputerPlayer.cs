using System;
using System.Collections.Generic;
using System.Text;
using BattleOfCardsAPI;

namespace BattleOfCards
{
    class ConsoleComputerPlayer : Player
    {
        Random rng;
        public ConsoleComputerPlayer(string Name) : base(Name)
        {
            Random rng = new Random();
        }

        public override Attributes ChooseAttribute()
        {
            Dictionary<int, string> botMenu = new Dictionary<int, string>() { { 1, "Coding"},
                                                                              { 2, "Gaming"},
                                                                              { 3, "SoftSkills" },
                                                                              { 4, "CoffeeConsuption"} };
            int randomMenu = rng.Next(0, botMenu.Count - 1);


            Console.WriteLine($"The bot({Name}),choosen the {botMenu[randomMenu]}");
            Console.WriteLine($"The bot({Name})'s first card is {Hand[0].ToString()}");
            
            Attributes answer = (Attributes)Enum.Parse(typeof(Attributes), menuAnswer, true);
            Console.WriteLine($"Your chosen stat is {menuAnswer}");
            return answer;
        }
    }
}
