using System;
using AVFoundation;
using AudioToolbox;
using AppKit;
using Foundation;

namespace NyanCat_C_Sharp
{
    public partial class ViewController : NSViewController
    {
        private bool isMuted = false;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override NSTouchBar TouchBar => myTouchbar; // Default touchbar settled to custom touchbar.

        private AVAudioPlayer backgroundNyanCatPlayer;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //NSApplication.SharedApplication.Windows[0].Level = NSWindowLevel.ScreenSaver;
            //NSApplication.SharedApplication.ActivateIgnoringOtherApps(true);
            NSUrl songURL = new NSUrl("nyan_music.mp3");
            NSError err;
            backgroundNyanCatPlayer = AVAudioPlayer.FromUrl(songURL, out err);
            backgroundNyanCatPlayer.Volume = 1;
            backgroundNyanCatPlayer.NumberOfLoops = -1;
            backgroundNyanCatPlayer.Play();
            // Do any additional setup after loading the view.
        }

        partial void btnMusic_Clicked(Foundation.NSObject sender)
        {
            if(!isMuted)
            {
                btnMusic.Image = NSImage.ImageNamed(NSImageName.TouchBarPlayTemplate);
                backgroundNyanCatPlayer.Pause();
            }

            else
            {
                btnMusic.Image = NSImage.ImageNamed(NSImageName.TouchBarPauseTemplate);
                backgroundNyanCatPlayer.Play();
            }

            isMuted = !isMuted;
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
