# Local Notifications Plugin (Notifier)

Notifier provides a consistent and easy way to show local notifications from within a native mobile app with a single line of code. Notifications are handled and displayed natively for each respective platform OS so they will appear in the notification center on iOS, Android and Windows Phone and will display a toast on Windows and Windows Phone.

## Methods

    void Show(string title, string body);

Usage:

    Notifier.Current.Show("You've got mail", "You have 793 unread messages!");

## Platform Specific Notes

Some platforms require some options to be set before it will display notifications.

### Windows and Windows Phone
You must enable notifications in the app manifest by setting the "Toast capable" property to "Yes".

### iOS (as of iOS 8) 

You must get permission from the user to allow the app to show local notifications.  Details on how to do this are here thanks to [Larry O'Brien](https://twitter.com/lobrien): [http://www.knowing.net/index.php/2014/07/03/local-notifications-in-ios-8-with-xamarin/](http://www.knowing.net/index.php/2014/07/03/local-notifications-in-ios-8-with-xamarin/)


