using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUIAgilityPack
{
    internal static class LoadPageControls
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

        internal static HtmlComboBox GetComboboxByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlControl genericControl = GetHtmlControlsByIdOrName(_browserWindow, controlName);
            HtmlComboBox htmlComboBox = new HtmlComboBox();

            if (genericControl != null)
            {
                htmlComboBox.CopyFrom(genericControl);
                return htmlComboBox;
            }

            return null;
        }

        internal static HtmlCheckBox GetCheckBoxByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlControl genericControl = GetHtmlControlsByIdOrName(_browserWindow, controlName);
            HtmlCheckBox htmlCheckBox = new HtmlCheckBox();

            if (genericControl != null)
            {
                htmlCheckBox.CopyFrom(genericControl);
                return htmlCheckBox;
            }

            return null;
        }

        internal static HtmlButton GetButton(BrowserWindow _browserWindow, SearchBy searchBy, string control)
        {
            HtmlControl genericControl;

            if (searchBy == SearchBy.ID)
                genericControl = GetHtmlControlsByIdOrName(_browserWindow, control);
            else
                genericControl = GetHtmlControlsByClassName(_browserWindow, control);

            HtmlButton htmlButton = new HtmlButton();

            if (genericControl != null)
            {
                htmlButton.CopyFrom(genericControl);
                return htmlButton;
            }

            return null;
        }

        internal static HtmlEdit GetTextBoxByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlControl genericControl = GetHtmlControlsByIdOrName(_browserWindow, controlName);
            HtmlEdit htmlEdit = new HtmlEdit();

            if (genericControl != null)
            {
                htmlEdit.CopyFrom(genericControl);
                return htmlEdit;
            }

            return null;
        }

        internal static HtmlRadioButton GetRadioButtonByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlControl genericControl = GetHtmlControlsByIdOrName(_browserWindow, controlName);
            HtmlRadioButton htmlRadioButton = new HtmlRadioButton();

            if (genericControl != null)
            {
                htmlRadioButton.CopyFrom(genericControl);
                return htmlRadioButton;
            }

            return null;
        }

        internal static HtmlLabel GetLabelByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlControl genericControl = GetHtmlControlsByIdOrName(_browserWindow, controlName);
            HtmlLabel htmlLabel = new HtmlLabel();

            if (genericControl != null)
            {
                htmlLabel.CopyFrom(genericControl);
                return htmlLabel;
            }

            return null;
        }

        internal static HtmlSpan GetSpanByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlControl genericControl = GetHtmlControlsByIdOrName(_browserWindow, controlName);
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
