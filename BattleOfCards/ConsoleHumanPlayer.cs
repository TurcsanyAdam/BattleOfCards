using System;
using System.Collections.Generic;
using System.Text;
using BattleOfCardsAPI;

namespace BattleOfCards
{
    class ConsoleHumanPlayer : Player
    {
        public ConsoleHumanPlayer(string Name) : base(Name)
        {

        }

        public override Attributes ChooseAttribute()
        {
            Attributes answer = 0;

            while (true)
            {
                string menu = $"Please choose {Name} from the below specifications!\n" +
                   "(Coding) Coding skills\n" +
                   "(Gaming) Gaming skills\n" +
                   "(SoftSkills) Soft skills\n" +
                   "(CoffeeConsuption)Coffee consumption";

                Console.WriteLine(menu);
                Console.WriteLine($"Your first card is {Hand[0].ToString()}");
                string menuAnswer = Console.ReadLine();

                if (Enum.IsDefined(typeof(Attributes), menuAnswer))
                {
                    answer = (Attributes)Enum.Parse(typeof(Attributes), menuAnswer, true);
                    Console.WriteLine($"Your chosen stat is {menuAnswer}");
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
                
            

            return answer;

        }
    }
}
