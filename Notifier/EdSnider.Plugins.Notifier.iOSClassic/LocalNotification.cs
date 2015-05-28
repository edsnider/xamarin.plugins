using System;
using EdSnider.Plugins.Core;
#if __UNIFIED__
using Foundation;
using UIKit;
#else
using MonoTouch.Foundation;
using MonoTouch.UIKit;
#endif

namespace EdSnider.Plugins
{
    /// <summary>
    /// Notification implementation for iOS (iPad and iPhone)
    /// </summary>
    public class LocalNotification : ILocalNotification
    {
        private readonly UILocalNotification notification;

        public LocalNotification(UILocalNotification notification)
        {
            this.notification = notification;
        }

        public UILocalNotification UILocalNotification
        {
            get { return notification; }
        }
    }
}
