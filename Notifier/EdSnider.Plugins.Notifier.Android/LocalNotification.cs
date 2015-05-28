using Android.App;
using Android.Content;
using EdSnider.Plugins.Core;

namespace EdSnider.Plugins
{
    /// <summary>
    /// Notification implementation for Android
    /// </summary>
    public class LocalNotification : ILocalNotification
    {
        private readonly int notificationId;

        public LocalNotification(int notificationId)
        {
            this.notificationId = notificationId;
        }

        public int NotificationId
        {
            get { return notificationId; }
        }
    }
}
