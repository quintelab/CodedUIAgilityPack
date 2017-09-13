using Microsoft.VisualStudio.TestTools.UITesting;

namespace CodedUIAgilityPack
{
    public class Browse
    {
        private static BrowserWindow browserWindow;

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
