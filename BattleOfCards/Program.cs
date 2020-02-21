using System;
using System.Collections.Generic;
using BattleOfCardsAPI;

namespace BattleOfCards
{
    class Program 
    {
        static void Main(string[] args)
        {
            try
            {
                Utility utility = new Utility();
                utility.Run();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

    }
}
