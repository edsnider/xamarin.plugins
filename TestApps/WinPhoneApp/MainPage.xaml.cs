using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using EdSnider.Plugins;
using EdSnider.Plugins.Core;

namespace WinPhoneApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationCacheMode = NavigationCacheMode.Required;
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
