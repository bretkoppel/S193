using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Core;

namespace Matchismo
{
	public partial class MatchismoViewController : UIViewController
	{
		private int _flipCount;
		private Deck _deck;

		public MatchismoViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			_deck = new PlayingCardDeck ();
		}

		partial void card_Click (UIButton sender)
		{
			if (!string.IsNullOrEmpty (sender.CurrentTitle))
			{
				sender.SetBackgroundImage (UIImage.FromBundle ("cardback"), UIControlState.Normal);
				sender.SetTitle (string.Empty, UIControlState.Normal);
			}
			else
			{
				var card = _deck.DrawRandomCard ();
				if (card == null)
				{
					var alert = new UIAlertView ("No cards left in the deck!", string.Empty, null, "OK", null);
					alert.Show ();
					return;
				}

				sender.SetBackgroundImage (UIImage.FromBundle ("cardfront"), UIControlState.Normal);
				sender.SetTitle (card.Contents, UIControlState.Normal);
			}
			flipsLabel.Text = "Flips: " + ++_flipCount;
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

