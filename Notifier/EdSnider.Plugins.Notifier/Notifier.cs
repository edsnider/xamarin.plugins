using System;
using System.Threading;
using EdSnider.Plugins.Core;

namespace EdSnider.Plugins
{
    public class Notifier
    {
        private static Lazy<INotifierService> _notifier = new Lazy<INotifierService>(CreateNotifier, LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Gets the current platform specific INotifierService implementation.
        /// </summary>
        public static INotifierService Current
        {
            get
            {
                var val = _notifier.Value;
                if (val == null)
                    throw NotImplementedInReferenceAssembly();
                return val;
            }
        }

        private static INotifierService CreateNotifier()
        {
#if PCL
            return null;
#else
            return new NotifierService();
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException();
        }
    }
}
