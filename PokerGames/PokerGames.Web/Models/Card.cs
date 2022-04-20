using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerGames.Web.Models
{
    public class Card
    {

	   public int Rank { get; set; }

	   public Suit Suit { get; set; }

	   public string Name { get; set; }

	   public static List<string> Ranks { get { return new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" }; } }

	   public string ImageUrl { get; set; }


    }
}
