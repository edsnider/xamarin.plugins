using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using EdSnider.Plugins.Core;
using Uri = Android.Net.Uri;

namespace EdSnider.Plugins
{
    /// <summary>
    /// AppLookup implementation for Android
    /// </summary>
    public class AppLookupService : IAppLookupService
    {
        /// <summary>
        /// Check to see if an app is installed on the device.
        /// </summary>
        /// <param name="packageName">Package name of the app you're looking for (e.g., com.edsnider.myapp) ** REQUIRED FOR Android and Windows Phone **</param>
        /// <param name="packageUrl">Package URL of the app you're looking for (e.g., edsniderapp://) ** REQUIRED FOR iOS **</param>
        public bool IsInstalled(string packageName = "", string packageUrl = "")
        {
            try
            {
                Application.Context.PackageManager.GetPackageInfo(packageName, PackageInfoFlags.Activities);
                return true;
            }
            catch (PackageManager.NameNotFoundException)
            {
                return false;
            }
        }

        /// <summary>
        /// Open an app in the App Store.
        /// </summary>
        /// <param name="packageName">Package name of the app you want to open App Store (e.g., com.edsnider.myapp) ** REQUIRED FOR Android and Windows Phone **</param>
        /// <param name="appId">App Id of the app you want to open in the App Store ** REQUIRED FOR iOS **</param>
        /// <returns></returns>
        public void OpenInAppStore(string packageName = "", string appId = "")
        {
            try
            {
                var uri = Uri.Parse(string.Format("market://details?id={0}", packageName));
                var intent = new Intent(Intent.ActionView, uri);
                Application.Context.StartActivity(intent);
            }
            catch (ActivityNotFoundException e)
            {
                var uri = Uri.Parse(string.Format("https://play.google.com/store/apps/details?id={0}", packageName));
                var intent = new Intent(Intent.ActionView, uri);
                Application.Context.StartActivity(intent);
            }
        }
    }
}