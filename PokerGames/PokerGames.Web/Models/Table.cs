using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerGames.Web.Models
{
    public class Table
    {
	   public Deck Deck { get; set; }

	   public Player Player1 { get; set; } = new Player();

	   public Player Player2 { get; set; } = new Player();

	   public void StartNewGame()
	   {
		  Deck = new Deck();

		  for (int i = 0; i < 5; i++)
		  {
			 Player1.Cards.Add(Deck.GetNextCard());

			 Player2.Cards.Add(Deck.GetNextCard());
		  }
	   }
    }
}
