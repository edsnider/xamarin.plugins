namespace EdSnider.Plugins.Core
{
    public interface IAppLookupService
    {
        /// <summary>
        /// Check to see if an app is installed on the device.
        /// </summary>
        /// <param name="packageName">Package name of the app you're looking for (e.g., com.edsnider.myapp) ** REQUIRED FOR Android and Windows Phone **</param>
        /// <param name="packageUrl">Package URL of the app you're looking for (e.g., edsniderapp://) ** REQUIRED FOR iOS **</param>
        bool IsInstalled(string packageName = "", string packageUrl = "");
        
        /// <summary>
        /// Open an app in the App Store.
        /// </summary>
        /// <param name="packageName">Package name of the app you want to open App Store (e.g., com.edsnider.myapp) ** REQUIRED FOR Android and Windows Phone **</param>
        /// <param name="appId">App Id of the app you want to open in the App Store ** REQUIRED FOR iOS **</param>
        void OpenInAppStore(string packageName = "", string appId = "");

        // string GetCurrentVersion(string packageName);
        // DateTime GetDateLastUpdated(string packageName);
        // void Launch(string packageName);
    }
}
