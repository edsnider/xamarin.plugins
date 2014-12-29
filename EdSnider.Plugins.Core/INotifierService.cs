namespace EdSnider.Plugins.Core
{
    public interface INotifierService
    {
        /// <summary>
        /// Show a local notification
        /// </summary>
        /// <param name="title">Title of the notification</param>
        /// <param name="body">Body or description of the notification</param>
        void Show(string title, string body);
    }
}
