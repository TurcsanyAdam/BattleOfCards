using System;
using BattleOfCardsAPI;

namespace BattleOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Initializer initializer = new Initializer();
            foreach(Card card in initializer.Cards)
            {
                Console.WriteLine(card.Name);
            }
            Console.ReadLine();
        }
    }
}
