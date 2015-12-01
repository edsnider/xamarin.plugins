using System.Drawing;
using Foundation;
using UIKit;
using Plugin.LocalNotifications;

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

            var testNotifierButton = UIButton.FromType(UIButtonType.RoundedRect);
            var testAppLookupButton = UIButton.FromType(UIButtonType.RoundedRect);
            
            testNotifierButton.Frame = new RectangleF((float)View.Frame.Width / 2 - 100, 
                                          (float)View.Frame.Height / 2 - 25, 
                                          200, 
                                          50);

            testAppLookupButton.Frame = new RectangleF((float)View.Frame.Width / 2 - 100,
                                          (float)testNotifierButton.Frame.Y + (float)testNotifierButton.Frame.Height + 25,
                                          200,
                                          50);

            testNotifierButton.SetTitle("Show Notification", UIControlState.Normal);

            testAppLookupButton.SetTitle("Is Calendar App Installed", UIControlState.Normal);

            testNotifierButton.TouchUpInside += (sender, args) =>
            {
               
                CrossLocalNotifications.Current.Show("Test", "This is a test notification");
            };
            

            testNotifierButton.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleTopMargin | 
                                      UIViewAutoresizing.FlexibleBottomMargin;

            testAppLookupButton.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleTopMargin |
                                      UIViewAutoresizing.FlexibleBottomMargin;

            View.AddSubview(testNotifierButton);
            View.AddSubview(testAppLookupButton);
        }
    }
}