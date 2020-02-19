using NUnit.Framework;
using BattleOfCardsAPI;
using System.Collections.Generic;

namespace NUnitTestProject1
{
    public class Tests
    {
        Deck deck;
        List<Player> playerList;
        [SetUp]
        public void Setup()
        {
            playerList = new List<Player>();
            deck = new Deck();
            Player player1 = new HumanPlayer("Player 1");
            Player player2 = new HumanPlayer("Player 2");
            Player player3 = new HumanPlayer("Player 3");
            Player player4 = new HumanPlayer("Player 4");
            Player player5 = new HumanPlayer("Player 5");
            playerList.Add(player1);
            playerList.Add(player2);
            playerList.Add(player3);
            playerList.Add(player4);
            playerList.Add(player5);
        }

        [Test]
        public void CanWeAddCardToPlayersHands()
        {
            Card card = new Card();
            Player player = new HumanPlayer("Joe");

            player.AddCardToTheHand(card);
            Assert.IsTrue(player.Hand.Count == 1);
        }

        [Test]
        public void CanPlayerHandExceedMaxCards()
        {
            int maxCards = deck.Cards.Count / playerList.Count;

            deck.ShuffleAndDeal(playerList);
            foreach(Player player in playerList)
            {
                Assert.AreEqual(maxCards, player.Hand.Count);
            }
        }
    }
}