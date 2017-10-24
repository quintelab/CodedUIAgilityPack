using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUIAgilityPack
{
    internal static class LoadGenericControls
    {
        private static HtmlControl GetHtmlControlsByIdOrName(BrowserWindow _browserWindow, string controlID)
        {
            HtmlControl control = new HtmlControl(_browserWindow);
            control.SearchProperties["Id"] = controlID;
            control.SearchProperties["Name"] = controlID;

            if (control.TryFind())
                return control;

            return null;
        }

        private static HtmlControl GetHtmlControlsByClassName(BrowserWindow _browserWindow, string className)
        {
            HtmlControl control = new HtmlControl(_browserWindow);
            control.SearchProperties["Class"] = className;

            if (control.TryFind())
                return control;

            return null;
        }

        internal static HtmlControl GetHtmlControls(BrowserWindow _browserWindow, SearchBy searchBy, string control)
        {
            if (searchBy == SearchBy.ID)
                return GetHtmlControlsByIdOrName(_browserWindow, control);
            else
                return GetHtmlControlsByClassName(_browserWindow, control);
        }
    }
}
