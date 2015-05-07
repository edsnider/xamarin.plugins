using System;
using System.Threading;
using EdSnider.Plugins.Core;

namespace EdSnider.Plugins
{
    public class AppLookup
    {
        private static Lazy<IAppLookupService> _lookup = new Lazy<IAppLookupService>(CreateLookerUpper, LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Gets the current platform specific IAppLookupService implementation.
        /// </summary>
        public static IAppLookupService Current
        {
            get
            {
                var val = _lookup.Value;
                if (val == null)
                    throw NotImplementedInReferenceAssembly();
                return val;
            }
        }

        private static IAppLookupService CreateLookerUpper()
        {
#if PCL
            return null;
#else
            return new AppLookupService();
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException();
        }
    }
}
