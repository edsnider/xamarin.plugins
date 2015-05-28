using System;
using Android.App;
using Android.Content;
using EdSnider.Plugins.Core;

namespace EdSnider.Plugins
{
    /// <summary>
    /// Notifier implementation for Android
    /// </summary>
    public class NotifierService : INotifierService
    {
        /// <summary>
        /// Show a local notification in the Notification Area and Drawer.
        /// </summary>
        /// <param name="title">Title of the notification</param>
        /// <param name="body">Body or description of the notification</param>
        /// <returns>The notification that was displayed</returns>
        public ILocalNotification Show(string title, string body)
        {
            var notificationId = Guid.NewGuid().GetHashCode();

            var builder = new Notification.Builder(Application.Context);
            builder.SetContentTitle(title);
            builder.SetContentText(body);
            builder.SetSmallIcon(Resource.Drawable.Icon);

            var notification = builder.Build();

            var manager = Application.Context.GetSystemService(Context.NotificationService) as NotificationManager;

            manager.Notify(notificationId, notification);

            return new LocalNotification(notificationId);
        }

        /// <summary>
        /// Cancel a local notification in the Notification Area and Drawer.
        /// </summary>
        /// <param name="notification">The notification to cancel</param>
        public void Hide(ILocalNotification notification)
        {
            var manager = Application.Context.GetSystemService(Context.NotificationService) as NotificationManager;

            manager.Cancel(((LocalNotification)notification).NotificationId);
        }
    }
}