using System.Collections.Generic;

namespace PokerGames.Web.Models
{
    public class Suit
    {

	   private Suit(string name, string color)
	   {
		  Name = name;
		  Color = color;
	   }

	   
	   public string Name { get; set; }

	   public string Color { get; set; }

	   #region Static

	   public static List<Suit> Suits
	   {
		  get
		  {
			 return new List<Suit> { Club,
								Heart,
								Spade,
								Diamond
								
							   };
		  }
	   }

	   private static readonly Suit _clubs = new Suit("Clubs", "black");

	   private static readonly Suit _hearts = new Suit("Hearts", "red");

	   private static readonly Suit _spades = new Suit("Spades", "black");

	   private static readonly Suit _diamonds = new Suit("Diamonds", "red");

	   public static Suit Club { get { return _clubs; } }

	   public static Suit Heart { get { return _hearts; } }

	   public static Suit Spade { get { return _spades; } }

	   public static Suit Diamond { get { return _diamonds; } }
	   #endregion
    }
}