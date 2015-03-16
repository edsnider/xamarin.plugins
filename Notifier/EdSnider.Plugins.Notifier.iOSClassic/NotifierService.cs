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
    /// Notifier implementation for iOS (iPad and iPhone)
    /// </summary>
    public class NotifierService : INotifierService
    {
        /// <summary>
        /// Show a local notification in the Notification Center.
        /// </summary>
        /// <param name="title">Title of the notification</param>
        /// <param name="body">Body or description of the notification</param>
        public void Show(string title, string body)
        {
            var notification = new UILocalNotification
            {
                FireDate = (NSDate)DateTime.Now,
                AlertAction = title,
                AlertBody = body
            };

            UIApplication.SharedApplication.ScheduleLocalNotification(notification);
        }
    }
}
