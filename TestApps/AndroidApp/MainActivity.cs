using Android.App;
using Android.OS;
using Android.Widget;
using EdSnider.Plugins;

namespace AndroidApp
{
    [Activity(Label = "AndroidApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            
            var testNotifierButton = FindViewById<Button>(Resource.Id.TestNotifierButton);

            testNotifierButton.Click += delegate
            {
                Notifier.Current.Show("Test", "This is a test notification");
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

