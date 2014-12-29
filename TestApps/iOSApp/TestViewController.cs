using System.Drawing;
using Foundation;
using UIKit;

namespace iOSApp
{
    public partial class TestViewController : UIViewController
    {
        static bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }

        public TestViewController()
            : base(UserInterfaceIdiomIsPhone ? "TestViewController_iPhone" : "TestViewController_iPad", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Ask the user for permission to get notifications
            var settings = UIUserNotificationSettings.GetSettingsForTypes(
                    UIUserNotificationType.Alert | UIUserNotificationType.Badge | UIUserNotificationType.Sound,
                    new NSSet());
            UIApplication.SharedApplication.RegisterUserNotificationSettings(settings);

            View.Frame = UIScreen.MainScreen.Bounds;
            View.BackgroundColor = UIColor.White;
            View.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;

            var button = UIButton.FromType(UIButtonType.RoundedRect);

            float width = 100;

            button.Frame = new RectangleF((float)View.Frame.Width / 2 - 100, 
                                          (float)View.Frame.Height / 2 - 25, 
                                          200, 
                                          50);

            button.SetTitle("Show Notification", UIControlState.Normal);

            button.TouchUpInside += (sender, args) =>
            {
                EdSnider.Plugins.Notifier.Current.Show("Test", "This is a test notification");
            };

            button.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleTopMargin | 
                                      UIViewAutoresizing.FlexibleBottomMargin;

            View.AddSubview(button);
        }
    }
}