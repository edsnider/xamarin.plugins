Plugins for Xamarin and Windows
===============

A series (well, there is only one so far) of simple, cross-platform plugins for Xamarin and Windows native mobile apps. 

##Notifier
Notifier provides a consistent and easy way to show local notifications from within a native mobile app with a single line of code. Notifications are handled and displayed natively for each respective platform OS so they will appear in the notification center on iOS, Android and Windows Phone and will display a toast on Windows and Windows Phone.
On Android/iOS the notification sound and vibration are supported, too. They are disabled to default.

####Methods

    void Show(string title, string body);
    void Show(string title, string body, int id, DateTime notifyTime, bool hasSound, bool hasVibration);
    void Cancel(int id);

Usage:

    Notifier.Current.Show("You've got mail", "You have 793 unread messages!");
    Notifier.Current.Show("Good morning", "Time to get up!", 1, DateTime.Now.AddDays(1), true, true);
    Notifier.Current.Cancel(1);

####Platform Specific Notes
On Windows and Windows Phone you must enable notifications in the app manifest by setting the "Toast capable" property to "Yes".

On iOS (as of iOS 8) you must get permission from the user to allow the app to show local notifications.  Details on how to do this are here thanks to [Larry O'Brien](https://twitter.com/lobrien): [http://www.knowing.net/index.php/2014/07/03/local-notifications-in-ios-8-with-xamarin/](http://www.knowing.net/index.php/2014/07/03/local-notifications-in-ios-8-with-xamarin/)
Every notification with sound will vibrate default.

####Download
[https://www.nuget.org/packages/Xam.Plugins.Notifier/](https://www.nuget.org/packages/Xam.Plugins.Notifier/)

####Supported Platforms
* Xamarin.iOS (Classic and Unified)
* Xamarin.Android
* Windows 8.1
* Windows Phone 8.1
* Windows Phone Silverlight 8.1
* Windows 10 UWP

####Features Coming Soon
* App launch deep linking
