using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using EdSnider.Plugins.Core;

namespace EdSnider.Plugins
{
    /// <summary>
    /// Notification implementation for Windows
    /// </summary>
    public class LocalNotification : ILocalNotification
    {
        private readonly ToastNotification notification;

        public LocalNotification(ToastNotification notification)
        {
            this.notification = notification;
        }

        public ToastNotification ToastNotification
        {
            get { return notification; }
        }
    }
}
