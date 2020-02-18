using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace BattleOfCardsAPI
{
    class Comparer
    {
        public class SortCodingDescending : IComparer
        {
           int IComparer.Compare(object card1, object card2)
            {
                Card c1 = (Card)card1;
                Card c2 = (Card)card2;
                if (c1.Coding < c2.Coding)
                    return 1;
                if (c1.Coding > c2.Coding)
                    return -1;
                else
                    return 0;
            }
        }
        public class SortGamingDescending : IComparer
        {
            int IComparer.Compare(object card1, object card2)
            {
                Card c1 = (Card)card1;
                Card c2 = (Card)card2;
                if (c1.Gaming < c2.Gaming)
                    return 1;
                if (c1.Gaming > c2.Gaming)
                    return -1;
                else
                    return 0;
            }
        }
        public class SortSoftSkillDescending : IComparer
        {
            int IComparer.Compare(object card1, object card2)
            {
                Card c1 = (Card)card1;
                Card c2 = (Card)card2;
                if (c1.SoftSkills < c2.SoftSkills)
                    return 1;
                if (c1.SoftSkills > c2.SoftSkills)
                    return -1;
                else
                    return 0;
            }
        }
        public class SortCoffeeConsuptionAscending : IComparer
        {
            int IComparer.Compare(object card1, object card2)
            {
                Card c1 = (Card)card1;
                Card c2 = (Card)card2;
                if (c1.CoffeeConsumption < c2.CoffeeConsumption)
                    return 1;
                if (c1.CoffeeConsumption < c2.CoffeeConsumption)
                    return -1;
                else
                    return 0;
            }
        }
    }
}
