using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Downloader.Manager.RNDownloaderManager
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNDownloaderManagerModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNDownloaderManagerModule"/>.
        /// </summary>
        internal RNDownloaderManagerModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNDownloaderManager";
            }
        }
    }
}
