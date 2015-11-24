using System.IO;
using System.Xml.Serialization;
using Android.App;
using Android.Content;

namespace Plugin.LocalNotifications
{
    /// <summary>
    /// Broadcast receiver
    /// </summary>
    [BroadcastReceiver(Enabled = true, Label = "Local Notifications Plugin Broadcast Receiver")]
    public class ScheduledAlarmHandler : BroadcastReceiver
    {
        /// <summary>
        /// 
        /// </summary>
        public const string LocalNotificationKey = "LocalNotification";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="intent"></param>
        public override void OnReceive(Context context, Intent intent)
        {
            var extra = intent.GetStringExtra(LocalNotificationKey);
            var notification = serializeFromString(extra);

            var builder = new Notification.Builder(Application.Context)
                .SetContentTitle(notification.Title)
                .SetContentText(notification.Body)
                .SetSmallIcon(Application.Context.ApplicationInfo.Icon);
            var nativeNotification = builder.Build();

            var notificationManager = Application.Context.GetSystemService(Context.NotificationService) as NotificationManager;
            notificationManager.Notify(notification.Id, nativeNotification);
        }

        private LocalNotification serializeFromString(string notificationString)
        {
            var xmlSerializer = new XmlSerializer(typeof(LocalNotification));
            using (var stringReader = new StringReader(notificationString))
            {
                var notification = (LocalNotification)xmlSerializer.Deserialize(stringReader);
                return notification;
            }
        }
    }
}