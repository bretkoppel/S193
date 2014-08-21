// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace Matchismo
{
	[Register ("MatchismoViewController")]
	partial class MatchismoViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel flipsLabel { get; set; }

		[Action ("card_Click:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void card_Click (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (flipsLabel != null) {
				flipsLabel.Dispose ();
				flipsLabel = null;
			}
		}
	}
}
