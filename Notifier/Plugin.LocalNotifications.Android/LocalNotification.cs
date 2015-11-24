using System;

namespace Plugin.LocalNotifications
{
    class LocalNotification
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int Id { get; set; }
        public DateTime NotifyTime { get; set; }
    }
}