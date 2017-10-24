using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUIAgilityPack
{
    internal static class LoadPageControls
    {
        internal static HtmlButton GetButton(BrowserWindow _browserWindow, SearchBy searchBy, string control)
        {
            HtmlControl genericControl = LoadGenericControls.GetHtmlControls(_browserWindow, searchBy, control);
            HtmlButton htmlButton = new HtmlButton();

            if (genericControl != null)
            {
                htmlButton.CopyFrom(genericControl);
                return htmlButton;
            }

            return null;
        }

        internal static HtmlCheckBox GetCheckBox(BrowserWindow _browserWindow, SearchBy searchBy, string control)
        {
            HtmlControl genericControl = LoadGenericControls.GetHtmlControls(_browserWindow, searchBy, control);
            HtmlCheckBox htmlCheckBox = new HtmlCheckBox();

            if (genericControl != null)
            {
                htmlCheckBox.CopyFrom(genericControl);
                return htmlCheckBox;
            }

            return null;
        }

        internal static HtmlComboBox GetCombobox(BrowserWindow _browserWindow, SearchBy searchBy, string control)
        {
            HtmlControl genericControl = LoadGenericControls.GetHtmlControls(_browserWindow, searchBy, control);
            HtmlComboBox htmlComboBox = new HtmlComboBox();

            if (genericControl != null)
            {
                htmlComboBox.CopyFrom(genericControl);
                return htmlComboBox;
            }

            return null;
        }

        internal static HtmlEdit GetTextBox(BrowserWindow _browserWindow, SearchBy searchBy, string control)
        {
            HtmlControl genericControl = LoadGenericControls.GetHtmlControls(_browserWindow, searchBy, control);
            HtmlEdit htmlEdit = new HtmlEdit();

            if (genericControl != null)
            {
                htmlEdit.CopyFrom(genericControl);
                return htmlEdit;
            }

            return null;
        }

        internal static HtmlRadioButton GetRadioButton(BrowserWindow _browserWindow, SearchBy searchBy, string control)
        {
            HtmlControl genericControl = LoadGenericControls.GetHtmlControls(_browserWindow, searchBy, control);
            HtmlRadioButton htmlRadioButton = new HtmlRadioButton();

            if (genericControl != null)
            {
                htmlRadioButton.CopyFrom(genericControl);
                return htmlRadioButton;
            }

            return null;
        }

        internal static HtmlLabel GetLabel(BrowserWindow _browserWindow, SearchBy searchBy, string control)
        {
            HtmlControl genericControl = LoadGenericControls.GetHtmlControls(_browserWindow, searchBy, control);
            HtmlLabel htmlLabel = new HtmlLabel();

            if (genericControl != null)
            {
                htmlLabel.CopyFrom(genericControl);
                return htmlLabel;
            }

            return null;
        }

        internal static HtmlSpan GetSpan(BrowserWindow _browserWindow, SearchBy searchBy, string control)
        {
            HtmlControl genericControl = LoadGenericControls.GetHtmlControls(_browserWindow, searchBy, control);
            HtmlSpan htmlSpan = new HtmlSpan();

            if (genericControl != null)
            {
                htmlSpan.CopyFrom(genericControl);
                return htmlSpan;
            }

            return null;
        }
    }

    internal enum SearchBy
    {
        ID,
        ClassName
    }
}
