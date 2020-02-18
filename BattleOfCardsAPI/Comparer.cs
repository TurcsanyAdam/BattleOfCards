using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace BattleOfCardsAPI
{
    class Comparer
    {
        public class SortCodingDescending : IComparer<Card>
        {
           int IComparer<Card>.Compare(Card card1, Card card2)
            {
                
                if (card1.Coding < card2.Coding)
                    return 1;
                if (card1.Coding > card2.Coding)
                    return -1;
                else
                    return 0;
            }
        }
        public class SortGamingDescending : IComparer<Card>
        {
            int IComparer<Card>.Compare(Card card1, Card card2)
            {
                
                if (card1.Gaming < card2.Gaming)
                    return 1;
                if (card1.Gaming > card2.Gaming)
                    return -1;
                else
                    return 0;
            }
        }
        public class SortSoftSkillDescending : IComparer<Card>
        {
            int IComparer<Card>.Compare(Card card1, Card card2)
            {
                
                if (card1.SoftSkills < card2.SoftSkills)
                    return 1;
                if (card1.SoftSkills > card2.SoftSkills)
                    return -1;
                else
                    return 0;
            }
        }
        public class SortCoffeeConsuptionAscending : IComparer<Card>
        {
            int IComparer<Card>.Compare(Card card1, Card card2)
            {
               
                if (card1.CoffeeConsumption < card2.CoffeeConsumption)
                    return 1;
                if (card1.CoffeeConsumption < card2.CoffeeConsumption)
                    return -1;
                else
                    return 0;
            }
        }
    }
}
