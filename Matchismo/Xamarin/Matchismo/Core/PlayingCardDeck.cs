using System;

namespace Core
{
	public class PlayingCardDeck : Deck
	{
		public PlayingCardDeck ()
		{
			foreach (var suit in PlayingCard.ValidSuits)
				for (int i =1; i <= PlayingCard.MaxRank; i++)
				{
					var card = new PlayingCard ();
					card.Rank = i;
					card.Suit = suit;
					this.AddCard (card);
				}
		}
	}
}

