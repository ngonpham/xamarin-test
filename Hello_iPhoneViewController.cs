using System;
using System.Drawing;
using System.Json;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Hello_iPhone
{
	public partial class Hello_iPhoneViewController : UIViewController
	{
		protected int _numberOfTimesClicked = 0;

		public Hello_iPhoneViewController () : base ("Hello_iPhoneViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.btnClickMe.TouchUpInside += (sender, e) => {
				this._numberOfTimesClicked++;
				this.lblOutput.Text = "Clicked [" + this._numberOfTimesClicked.ToString() + "] times!";
			};
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void actnButtonClick (NSObject sender)
		{
			if (sender == btnClickMe2) {
				String content = SysUtils.downloadData("http://timvideo.com/api/film/list?cat=Vi%E1%BB%87t%20Nam");
				var obj = JsonObject.Parse(content);
				var data = obj["data"] as JsonArray;
				foreach (var film in data) {
					string genre = film["genre"];
					Console.Out.WriteLine(genre);
				}
				// this.lblOutput.Text = content;
			} else
				this.lblOutput.Text = "Action button " +  ((UIButton)sender).CurrentTitle + " clicked.";
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

