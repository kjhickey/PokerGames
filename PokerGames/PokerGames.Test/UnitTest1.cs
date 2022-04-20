using PokerGames.Web.Models;
using System;
using Xunit;

namespace PokerGames.Test
{
    public class UnitTest1
    {
	   [Fact]
	   public void SuitsAreEqual()
	   {
		  var clubs1 = Suit.Club;

		  var clubs2 = Suit.Club;

		  Assert.Equal(clubs1, clubs2);
	   }

	   [Fact]
	   public void DeckCreatesSuccessfully()
	   {
		  var deck = new Deck();

		  var firstCard = deck.GetNextCard();

		  var secondCard = deck.GetNextCard();

		  Assert.NotEqual(firstCard, secondCard);
	   }
    }
}
