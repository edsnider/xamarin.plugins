using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using EdSnider.Plugins.Core;

namespace EdSnider.Plugins
{
    /// <summary>
    /// Notifier implementation for Windows
    /// </summary>
    public class NotifierService : INotifierService
    {
        private const string _TOAST_TEXT02_TEMPLATE = "<toast>"
                                                    + "<visual>"
                                                    + "<binding template='ToastText02'>"
                                                    + "<text id='1'>{0}</text>"
                                                    + "<text id='2'>{1}</text>"
                                                    + "</binding>"
                                                    + "</visual>"
                                                    + "</toast>";

        /// <summary>
        /// Show a local toast notification.  Notification will also appear in the Notification Center on Windows Phone 8.1.
        /// </summary>
        /// <param name="title">Title of the notification</param>
        /// <param name="body">Body or description of the notification</param>
        public void Show(string title, string body)
        {
            var xmlData = string.Format(_TOAST_TEXT02_TEMPLATE, title, body);

            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlData);

            // Create a toast
            var toast = new ToastNotification(xmlDoc);
            
            // Create a toast notifier and show the toast
            var manager = ToastNotificationManager.CreateToastNotifier();
            manager.Show(toast);
        }
    }
}
