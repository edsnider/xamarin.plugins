using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using EdSnider.Plugins;
using EdSnider.Plugins.Core;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WinPhoneSLApp.Resources;

namespace WinPhoneSLApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        ILocalNotification notification = null;

        private void SendToastClick(object sender, RoutedEventArgs e)
        {
            notification = Notifier.Current.Show("Test", "This is a test notification");
        }

        private void CancelToastClick(object sender, RoutedEventArgs e)
        {
            if (notification != null)
            {
                Notifier.Current.Hide(notification);
                notification = null;
            }
        }
    }
}