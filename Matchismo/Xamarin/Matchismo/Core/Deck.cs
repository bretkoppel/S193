using System;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
	public class Deck
	{
		private readonly List<Card> _cards;

		public Deck ()
		{
			_cards = new List<Card> ();
		}

		public void AddCard(Card card, bool atTop = false)
		{
			if (atTop)
				_cards.Insert (0, card);
			else
				_cards.Add (card);
		}

		public Card DrawRandomCard()
		{
			if (!_cards.Any ())
				return null;

			var rand = new Random ();
			var index = rand.Next () % _cards.Count;
			var card = _cards [index];
			_cards.Remove (card);
			return card;
		}
	}
}

