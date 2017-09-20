using Microsoft.VisualStudio.TestTools.UITesting;

namespace CodedUIAgilityPack
{
    /// <summary>
    /// Class representing a Browser Window
    /// </summary>
    public class Browse
    {
        private static BrowserWindow browserWindow;

        /// <summary>
        /// Browser object
        /// </summary>
        public static BrowserWindow BrowserWindow
        {
            get
            {
                return browserWindow;
            }
            set
            {
                browserWindow = value;
            }
        }
    }
}
