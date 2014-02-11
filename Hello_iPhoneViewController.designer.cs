// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Hello_iPhone
{
	[Register ("Hello_iPhoneViewController")]
	partial class Hello_iPhoneViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton btnClickMe { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton btnClickMe2 { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel lblOutput { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISlider sld1 { get; set; }

		[Action ("actnButtonClick:")]
		partial void actnButtonClick (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (btnClickMe != null) {
				btnClickMe.Dispose ();
				btnClickMe = null;
			}

			if (btnClickMe2 != null) {
				btnClickMe2.Dispose ();
				btnClickMe2 = null;
			}

			if (lblOutput != null) {
				lblOutput.Dispose ();
				lblOutput = null;
			}

			if (sld1 != null) {
				sld1.Dispose ();
				sld1 = null;
			}
		}
	}
}
