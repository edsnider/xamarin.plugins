using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace NotifierSample.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// Ask the user for permission to get notifications on iOS 8.0+
			if (UIDevice.CurrentDevice.CheckSystemVersion (8, 0)) {
				var settings = UIUserNotificationSettings.GetSettingsForTypes (
					UIUserNotificationType.Alert | UIUserNotificationType.Badge | UIUserNotificationType.Sound,
					new NSSet ());
				UIApplication.SharedApplication.RegisterUserNotificationSettings (settings);
			}

			global::Xamarin.Forms.Forms.Init ();

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}

