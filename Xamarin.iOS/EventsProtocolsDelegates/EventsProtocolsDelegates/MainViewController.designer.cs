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

namespace EventsProtocolsDelegates
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_GoForward { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btn_GoForward != null) {
				btn_GoForward.Dispose ();
				btn_GoForward = null;
			}
		}
	}
}
