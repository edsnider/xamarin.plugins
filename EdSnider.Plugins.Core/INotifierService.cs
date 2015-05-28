namespace EdSnider.Plugins.Core
{
    public interface INotifierService
    {
        /// <summary>
        /// Show a local notification
        /// </summary>
        /// <param name="title">Title of the notification</param>
        /// <param name="body">Body or description of the notification</param>
        /// <returns>The notification that was displayed</returns>
        ILocalNotification Show(string title, string body);

        /// <summary>
        /// Cancel a local notification
        /// </summary>
        /// <param name="notification">The notification to cancel</param>
        void Hide(ILocalNotification notification);
    }
}
