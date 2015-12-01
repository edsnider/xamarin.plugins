using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Plugin.LocalNotifications;
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
        
        private void SendToastClick(object sender, RoutedEventArgs e)
        {
            CrossLocalNotifications.Current.Show("Test", "This is a test notification");
        }
    }
}