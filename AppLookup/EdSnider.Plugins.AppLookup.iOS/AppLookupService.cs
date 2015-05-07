using System;
using EdSnider.Plugins.Core;
using Foundation;
using UIKit;

namespace EdSnider.Plugins
{
    /// <summary>
    /// AppLookup implementation for iOS
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
                return UIApplication.SharedApplication.CanOpenUrl(new NSUrl(packageUrl));
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void OpenInAppStore(string packageName = "", string appId = "")
        {
            var uri = new NSUrl(string.Format("itms-apps://itunes.apple.com/app/id{0}", appId));
            UIApplication.SharedApplication.OpenUrl(uri);
        }
    }
}