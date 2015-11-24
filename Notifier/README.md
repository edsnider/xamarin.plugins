# Local Notifications Plugin (Notifier)

Notifier provides a consistent and easy way to show local notifications from within a native mobile app with a single line of code. Notifications are handled and displayed natively for each respective platform OS so they will appear in the notification center on iOS, Android and Windows Phone and will display a toast on Windows and Windows Phone.

## Methods

```csharp
        /// <summary>
        /// Show a local notification
        /// </summary>
        /// <param name="title">Title of the notification</param>
        /// <param name="body">Body or description of the notification</param>
        /// <param name="id">Id of the notification</param>
        void Show(string title, string body, int id = 0);
```

Timed Notification

```csharp
        /// <summary>
        /// Show a local notification at a specified time
        /// </summary>
        /// <param name="title">Title of the notification</param>
        /// <param name="body">Body or description of the notification</param>
        /// <param name="id">Id of the notification</param>
        /// <param name="notifyTime">Time to show notification</param>
        void Show(string title, string body, int id, DateTime notifyTime);
```

Cancel Notification
```csharp
        /// <summary>
        /// Cancel a local notification
        /// </summary>
        /// <param name="id">Id of the scheduled notification you'd like to cancel</param>
        void Cancel(int id);
```

Usage:

    Notifier.Current.Show("You've got mail", "You have 793 unread messages!");

**Supports**
* Xamarin.iOS
* Xamarin.iOS (x64 Unified)
* Xamarin.Android
* Windows Phone 8.1 (Silverlight) (8.0 not supported)
* Windows Ptone 8.1 RT
* Windows Store 8.1
* UWP - Windows 10


## Platform Specific Notes

Some platforms require some options to be set before it will display notifications.

### Windows and Windows Phone
You must enable notifications in the app manifest by setting the "Toast capable" property to "Yes".

### iOS (as of iOS 8) 
You must get permission from the user to allow the app to show local notifications.  Details on how to do this are here thanks to [Larry O'Brien](https://twitter.com/lobrien): [http://www.knowing.net/index.php/2014/07/03/local-notifications-in-ios-8-with-xamarin/](http://www.knowing.net/index.php/2014/07/03/local-notifications-in-ios-8-with-xamarin/)


