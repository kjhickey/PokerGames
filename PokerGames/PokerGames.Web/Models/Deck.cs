using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerGames.Web.Models
{
    public class Deck
    {
	   private static List<Card> _cards;

	   public Card GetNextCard()
	   {
		  return Cards.Dequeue();
	   }

	   public Deck()
	   {
            _cards = CreateAllCards();
            var rnd = new Random();
            var shuffledCards = _cards.OrderBy(card => rnd.Next());
            Cards = new Queue<Card>(shuffledCards);
	   }

	   private Queue<Card> Cards { get; set; }

        private List<Card> CreateAllCards()
        {
            return new List<Card>
            {
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/Playing_card_club_A.svg/200px-Playing_card_club_A.svg.png",
                    Name = "Ace of Clubs",
                    Rank = 14,
                    Suit = Suit.Club
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d3/Playing_card_diamond_A.svg/200px-Playing_card_diamond_A.svg.png",
                    Name = "Ace of Diamonds",
                    Rank = 14,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/57/Playing_card_heart_A.svg/200px-Playing_card_heart_A.svg.png",
                    Name = "Ace of Hearts",
                    Rank = 14,
                    Suit = Suit.Heart
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Playing_card_spade_A.svg/200px-Playing_card_spade_A.svg.png",
                    Name = "Ace of Spades",
                    Rank = 14,
                    Suit = Suit.Spade
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/22/Playing_card_club_K.svg/200px-Playing_card_club_K.svg.png",
                    Name = "King of Clubs",
                    Rank = 13,
                    Suit = Suit.Club
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Playing_card_diamond_K.svg/200px-Playing_card_diamond_K.svg.png",
                    Name = "King of Diamonds",
                    Rank = 13,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dc/Playing_card_heart_K.svg/200px-Playing_card_heart_K.svg.png",
                    Name = "King of Hearts",
                    Rank = 13,
                    Suit = Suit.Heart
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Playing_card_spade_K.svg/200px-Playing_card_spade_K.svg.png",
                    Name = "King of Spades",
                    Rank = 13,
                    Suit = Suit.Spade
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Playing_card_club_Q.svg/200px-Playing_card_club_Q.svg.png",
                    Name = "Queen of Clubs",
                    Rank = 12,
                    Suit = Suit.Club
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Playing_card_diamond_Q.svg/200px-Playing_card_diamond_Q.svg.png",
                    Name = "Queen of Diamonds",
                    Rank = 12,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/72/Playing_card_heart_Q.svg/200px-Playing_card_heart_Q.svg.png",
                    Name = "Queen of Hearts",
                    Rank = 12,
                    Suit = Suit.Heart
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/51/Playing_card_spade_Q.svg/200px-Playing_card_spade_Q.svg.png",
                    Name = "Queen of Spades",
                    Rank = 12,
                    Suit = Suit.Spade
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Playing_card_club_J.svg/200px-Playing_card_club_J.svg.png",
                    Name = "Jack of Clubs",
                    Rank = 11,
                    Suit = Suit.Club
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Playing_card_diamond_J.svg/200px-Playing_card_diamond_J.svg.png",
                    Name = "Jack of Diamonds",
                    Rank = 11,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/46/Playing_card_heart_J.svg/200px-Playing_card_heart_J.svg.png",
                    Name = "Jack of Hearts",
                    Rank = 11,
                    Suit = Suit.Heart
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Playing_card_spade_J.svg/200px-Playing_card_spade_J.svg.png",
                    Name = "Jack of Spades",
                    Rank = 11,
                    Suit = Suit.Spade
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Playing_card_club_10.svg/200px-Playing_card_club_10.svg.png",
                    Name = "10 of Clubs",
                    Rank = 10,
                    Suit = Suit.Club
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/34/Playing_card_diamond_10.svg/200px-Playing_card_diamond_10.svg.png",
                    Name = "10 of Diamonds",
                    Rank = 10,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/98/Playing_card_heart_10.svg/200px-Playing_card_heart_10.svg.png",
                    Name = "10 of Hearts",
                    Rank = 10,
                    Suit = Suit.Heart
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Playing_card_spade_10.svg/200px-Playing_card_spade_10.svg.png",
                    Name = "10 of Spades",
                    Rank = 10,
                    Suit = Suit.Spade
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/27/Playing_card_club_9.svg/200px-Playing_card_club_9.svg.png",
                    Name = "9 of Clubs",
                    Rank = 9,
                    Suit = Suit.Club
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9e/Playing_card_diamond_9.svg/200px-Playing_card_diamond_9.svg.png",
                    Name = "9 of Diamonds",
                    Rank = 9,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/50/Playing_card_heart_9.svg/200px-Playing_card_heart_9.svg.png",
                    Name = "9 of Hearts",
                    Rank = 9,
                    Suit = Suit.Heart
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e0/Playing_card_spade_9.svg/200px-Playing_card_spade_9.svg.png",
                    Name = "9 of Spades",
                    Rank = 9,
                    Suit = Suit.Spade
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/eb/Playing_card_club_8.svg/200px-Playing_card_club_8.svg.png",
                    Name = "8 of Clubs",
                    Rank = 8,
                    Suit = Suit.Club
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Playing_card_diamond_8.svg/200px-Playing_card_diamond_8.svg.png",
                    Name = "8 of Diamonds",
                    Rank = 8,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/50/Playing_card_heart_8.svg/200px-Playing_card_heart_8.svg.png",
                    Name = "8 of Hearts",
                    Rank = 8,
                    Suit = Suit.Heart
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Playing_card_spade_8.svg/200px-Playing_card_spade_8.svg.png",
                    Name = "8 of Spades",
                    Rank = 8,
                    Suit = Suit.Spade
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Playing_card_club_7.svg/200px-Playing_card_club_7.svg.png",
                    Name = "7 of Clubs",
                    Rank = 7,
                    Suit = Suit.Club
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Playing_card_diamond_7.svg/200px-Playing_card_diamond_7.svg.png",
                    Name = "7 of Diamonds",
                    Rank = 7,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/94/Playing_card_heart_7.svg/200px-Playing_card_heart_7.svg.png",
                    Name = "7 of Hearts",
                    Rank = 7,
                    Suit = Suit.Heart
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/66/Playing_card_spade_7.svg/200px-Playing_card_spade_7.svg.png",
                    Name = "7 of Spades",
                    Rank = 7,
                    Suit = Suit.Spade
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Playing_card_club_6.svg/200px-Playing_card_club_6.svg.png",
                    Name = "6 of Clubs",
                    Rank = 6,
                    Suit = Suit.Club
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Playing_card_diamond_6.svg/200px-Playing_card_diamond_6.svg.png",
                    Name = "6 of Diamonds",
                    Rank = 6,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Playing_card_heart_6.svg/200px-Playing_card_heart_6.svg.png",
                    Name = "6 of Hearts",
                    Rank = 6,
                    Suit = Suit.Heart
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d2/Playing_card_spade_6.svg/200px-Playing_card_spade_6.svg.png",
                    Name = "6 of Spades",
                    Rank = 6,
                    Suit = Suit.Spade
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/50/Playing_card_club_5.svg/200px-Playing_card_club_5.svg.png",
                    Name = "5 of Clubs",
                    Rank = 5,
                    Suit = Suit.Club
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fd/Playing_card_diamond_5.svg/200px-Playing_card_diamond_5.svg.png",
                    Name = "5 of Diamonds",
                    Rank = 5,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Playing_card_heart_5.svg/200px-Playing_card_heart_5.svg.png",
                    Name = "5 of Hearts",
                    Rank = 5,
                    Suit = Suit.Heart
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/94/Playing_card_spade_5.svg/200px-Playing_card_spade_5.svg.png",
                    Name = "5 of Spades",
                    Rank = 5,
                    Suit = Suit.Spade
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3d/Playing_card_club_4.svg/200px-Playing_card_club_4.svg.png",
                    Name = "4 of Clubs",
                    Rank = 4,
                    Suit = Suit.Club
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Playing_card_diamond_4.svg/200px-Playing_card_diamond_4.svg.png",
                    Name = "4 of Diamonds",
                    Rank = 4,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Playing_card_heart_4.svg/200px-Playing_card_heart_4.svg.png",
                    Name = "4 of Hearts",
                    Rank = 4,
                    Suit = Suit.Heart
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Playing_card_spade_4.svg/200px-Playing_card_spade_4.svg.png",
                    Name = "4 of Spades",
                    Rank = 4,
                    Suit = Suit.Spade
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6b/Playing_card_club_3.svg/200px-Playing_card_club_3.svg.png",
                    Name = "3 of Clubs",
                    Rank = 3,
                    Suit = Suit.Club
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/82/Playing_card_diamond_3.svg/200px-Playing_card_diamond_3.svg.png",
                    Name = "3 of Diamonds",
                    Rank = 3,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b6/Playing_card_heart_3.svg/200px-Playing_card_heart_3.svg.png",
                    Name = "3 of Hearts",
                    Rank = 3,
                    Suit = Suit.Heart
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/52/Playing_card_spade_3.svg/200px-Playing_card_spade_3.svg.png",
                    Name = "3 of Spades",
                    Rank = 3,
                    Suit = Suit.Spade
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f5/Playing_card_club_2.svg/200px-Playing_card_club_2.svg.png",
                    Name = "2 of Clubs",
                    Rank = 2,
                    Suit = Suit.Club
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Playing_card_diamond_2.svg/200px-Playing_card_diamond_2.svg.png",
                    Name = "2 of Diamonds",
                    Rank = 2,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d5/Playing_card_heart_2.svg/200px-Playing_card_heart_2.svg.png",
                    Name = "2 of Hearts",
                    Rank = 2,
                    Suit = Suit.Heart
                },
                new Card
                {
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Playing_card_spade_2.svg/200px-Playing_card_spade_2.svg.png",
                    Name = "2 of Spades",
                    Rank = 2,
                    Suit = Suit.Spade
                }
            };
        }

    }
}
