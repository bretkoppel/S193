using System;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class Card
	{
		public virtual string Contents { get; set;}

		public bool Chosen {get;set;}

		public bool Matched {get;set;}

		public int Match(IEnumerable<Card> otherCards)
		{
			var score = 0;
			foreach (var card in otherCards)
			{
				if (card.Contents == this.Contents)
					score = 1;
			}

			return score;
		}
	}
}

