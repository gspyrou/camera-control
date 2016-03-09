using System;

using UIKit;

namespace Camera
{
	public partial class ViewController : UIViewController
	{
		bool flashOn = false;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

		partial void TakePhotoButtonTapped (UIButton sender)
		{
			Console.WriteLine ("TakePhotoButtonTapped");
		}

		partial void SwitchCameraButtonTapped (UIButton sender)
		{
			Console.WriteLine ("SwitchCameraButtonTapped");
		}

		partial void FlashButtonTapped (UIButton sender)
		{
			if (flashOn) {
				flashButton.SetBackgroundImage (UIImage.FromBundle ("NoFlashButton.png"), UIControlState.Normal);
			} else {
				flashButton.SetBackgroundImage (UIImage.FromBundle ("FlashButton.png"), UIControlState.Normal);
			}

			flashOn = !flashOn;
		}
	}
}