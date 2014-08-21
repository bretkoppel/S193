using System;
using System.Collections;
using System.Collections.Generic;

namespace Core
{
	public class PlayingCard : Card
	{
		private string _suit = string.Empty;
		private int _rank;

		public override string Contents {
			get { return RankStrings [_rank] + _suit; }
			set { base.Contents = value; }
		}

		public string Suit
		{
			get{ return string.IsNullOrEmpty (_suit) ? "?" : _suit;}

			set
			{
				if (ValidSuits.Contains (value))
					_suit = value;
			}
		}

		public int Rank
		{
			get {return _rank;}
			set 
			{
				if (value <= MaxRank)
					_rank = value;
			}
		}

		public static IList<string> ValidSuits { get { return new[] {@"♣︎",@"♦︎",@"♥︎",@"♠︎"}; } }

		private static IList<string> RankStrings {
			get {
				return new[] {
					@"?",
					@"A",
					@"2",
					@"3",
					@"4",
					@"5",
					@"6",
					@"7",
					@"8",
					@"9",
					@"10",
					@"J",
					@"Q",
					@"K"
			};
			}
		}

		public static int MaxRank { get { return RankStrings.Count - 1; } }
	}
}

