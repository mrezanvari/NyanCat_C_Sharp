using System;
using AppKit;
using Foundation;

namespace NyanCat_C_Sharp
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        public AppDelegate()
        {
        }

        public override bool ApplicationShouldTerminateAfterLastWindowClosed(NSApplication sender) //Close App when window closed
        {
            return true;
        }

        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application

            try
            {
                NSApplication.SharedApplication.SetAutomaticCustomizeTouchBarMenuItemEnabled(true); // Enable custom touchbar.
                NSApplication.SharedApplication.SetTouchBar(NSApplication.SharedApplication.MainWindow.ContentViewController.TouchBar);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRR: \r\n" + ex.Message + "\r\n"); // should never happen but just in case.
            }
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
