// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NyanCat_C_Sharp
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton btnMusic { get; set; }

		[Outlet]
		AppKit.NSTouchBar myTouchbar { get; set; }

		[Action ("btnMusic_Clicked:")]
		partial void btnMusic_Clicked (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (btnMusic != null) {
				btnMusic.Dispose ();
				btnMusic = null;
			}

			if (myTouchbar != null) {
				myTouchbar.Dispose ();
				myTouchbar = null;
			}
		}
	}
}
