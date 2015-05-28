using Android.App;
using Android.OS;
using Android.Widget;
using EdSnider.Plugins;
using EdSnider.Plugins.Core;

namespace AndroidApp
{
    [Activity(Label = "AndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            
            var testNotifierButton = FindViewById<Button>(Resource.Id.TestNotifierButton);

            ILocalNotification notification = null;

            testNotifierButton.Click += delegate
            {
                notification = Notifier.Current.Show("Test", "This is a test notification");
            };

            var testNotifierCancelButton = FindViewById<Button>(Resource.Id.TestNotifierCancelButton);

            testNotifierCancelButton.Click += delegate
            {
                if (notification != null)
                {
                    Notifier.Current.Hide(notification);
                    notification = null;
                }
            };

            var testAppLookupButton = FindViewById<Button>(Resource.Id.TestAppLookupButton);

            testAppLookupButton.Click += delegate
            {
                var calApp = "com.android.calendar";
                var noApp = "com.noapphasthiscrazyname";

                var isCalAppInstalled = AppLookup.Current.IsInstalled(packageName: calApp);
                var isNoAppInstalled = AppLookup.Current.IsInstalled(packageName: noApp);

                var msg = "Calendar app is" + (isCalAppInstalled ? " " : " NOT ") + "installed.";

                var builder = new AlertDialog.Builder(this);
                var alert = builder.Create();
                alert.SetTitle("AppLookup Test");
                alert.SetMessage(msg);
                alert.Show();
            };
        }
    }
}

