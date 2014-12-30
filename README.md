Plugins for Xamarin and Windows
===============

A series (well, there is only one so far) of simple, cross-platform plugins for Xamarin and Windows native mobile apps. 

##Notifier
Notifier provides a consistent and easy way to show local notifications from within a native mobile app with a single line of code. Notifications are handled and displayed natively for each respective platform OS so they will appear in the notification center on iOS, Android and Windows Phone and will display a toast on Windows and Windows Phone.

####Methods

    void Show(string title, string body);

Usage:

    Notifier.Current.Show("You've got mail", "You have 793 unread messages!");

####Platform Specific Notes
On Windows and Windows Phone you must enable notifications in the app manifest by setting the "Toast capable" property to "Yes".

On iOS (as of iOS 8) you must get permission from the user to allow the app to show local notifications.  Details on how to do this are here thanks to [Larry O'Brien](https://twitter.com/lobrien): [http://www.knowing.net/index.php/2014/07/03/local-notifications-in-ios-8-with-xamarin/](http://www.knowing.net/index.php/2014/07/03/local-notifications-in-ios-8-with-xamarin/)

####Download
[https://www.nuget.org/packages/Xam.Plugins.Notifier/](https://www.nuget.org/packages/Xam.Plugins.Notifier/)

####Supported Platforms
* Xamarin.iOS (Classic and Unified)
* Xamarin.Android
* Windows 8.1
* Windows Phone 8.1
* Windows Phone Silverlight 8.1

####Features Coming Soon
* Scheduled notifications
* Notification images
* App launch deep linking
* Xamarin.Forms support
