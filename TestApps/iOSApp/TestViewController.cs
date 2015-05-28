using System;
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

            var testNotifierButton = UIButton.FromType(UIButtonType.RoundedRect);
            var testNotifierCancelButton = UIButton.FromType(UIButtonType.RoundedRect);
            var testAppLookupButton = UIButton.FromType(UIButtonType.RoundedRect);
            
            testNotifierButton.Frame = new RectangleF((float)View.Frame.Width / 2 - 100, 
                                          (float)View.Frame.Height / 2 - 25, 
                                          200, 
                                          50);

            testNotifierCancelButton.Frame = new RectangleF((float)View.Frame.Width / 2 - 100,
                                          (float)testNotifierButton.Frame.Y + (float)testNotifierButton.Frame.Height + 25,
                                          200,
                                          50);

            testAppLookupButton.Frame = new RectangleF((float)View.Frame.Width / 2 - 100,
                                          (float)testNotifierCancelButton.Frame.Y + (float)testNotifierCancelButton.Frame.Height + 25,
                                          200,
                                          50);

            testNotifierButton.SetTitle("Show Notification", UIControlState.Normal);

            testNotifierCancelButton.SetTitle("Cancel Notification", UIControlState.Normal);

            testAppLookupButton.SetTitle("Is Calendar App Installed", UIControlState.Normal);

            EdSnider.Plugins.Core.ILocalNotification notification = null;

            testNotifierButton.TouchUpInside += (sender, args) =>
            {
                notification = EdSnider.Plugins.Notifier.Current.Show("Test", "This is a test notification");
            };

            testNotifierCancelButton.TouchUpInside += (sender, args) =>
            {
                if (notification != null)
                {
                    EdSnider.Plugins.Notifier.Current.Hide(notification);
                    notification = null;
                }
            };

            testAppLookupButton.TouchUpInside += (sender, args) =>
            {
                var calAppUrl = "calshow://";
                var noAppUrl = "noapphasthiscrazyurl://";

                var isCalAppInstalled = EdSnider.Plugins.AppLookup.Current.IsInstalled(packageUrl: calAppUrl);
                var isNoAppInstalled = EdSnider.Plugins.AppLookup.Current.IsInstalled(packageUrl: noAppUrl);

                var msg = "Calendar app is" + (isNoAppInstalled ? " " : " NOT ") + "installed.";

                UIAlertView alert = new UIAlertView("AppLookup Test", msg, null, "OK");
                alert.Show();
            };

            testNotifierButton.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleTopMargin | 
                                      UIViewAutoresizing.FlexibleBottomMargin;

            testAppLookupButton.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleTopMargin |
                                      UIViewAutoresizing.FlexibleBottomMargin;

            View.AddSubview(testNotifierButton);
            View.AddSubview(testNotifierCancelButton);
            View.AddSubview(testAppLookupButton);
        }
    }
}