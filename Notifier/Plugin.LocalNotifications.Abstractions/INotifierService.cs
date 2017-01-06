using System;

namespace Plugin.LocalNotifications.Abstractions
{
    /// <summary>
    /// Local Notification Interface
    /// </summary>
    public interface ILocalNotifications
    {
        /// <summary>
        /// Show a local notification
        /// </summary>
        /// <param name="title">Title of the notification</param>
        /// <param name="body">Body or description of the notification</param>
        /// <param name="hasSound">Bool to check notification sound</param>
        /// <param name="hasVibration">Bool to check notification vibration</param>
        /// <param name="id">Id of the notification</param>
        void Show(string title, string body, bool hasSound = false, bool hasVibration = false, int id = 0);

        /// <summary>
        /// Show a local notification at a specified time
        /// </summary>
        /// <param name="title">Title of the notification</param>
        /// <param name="body">Body or description of the notification</param>
        /// <param name="id">Id of the notification</param>
        /// <param name="notifyTime">Time to show notification</param>
        /// <param name="hasSound">Bool to check notification sound</param>
        /// <param name="hasVibration">Bool to check notification vibration</param>
        void Show(string title, string body, int id, DateTime notifyTime,  bool hasSound = false, bool hasVibration = false);

        /// <summary>
        /// Cancel a local notification
        /// </summary>
        /// <param name="id">Id of the scheduled notification you'd like to cancel</param>
        void Cancel(int id);
    }
}
