using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUIAgilityPack
{
    internal static class LoadPageControls
    {
        internal static HtmlComboBox GetComboboxByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlComboBox controls = new HtmlComboBox(_browserWindow);
            UITestControlCollection collection = controls.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlComboBox comboBox in collection)
                    if (comboBox.Id == controlName || comboBox.Name == controlName)
                        return comboBox;

            return null;
        }

        internal static HtmlCheckBox GetCheckBoxByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlCheckBox controls = new HtmlCheckBox(_browserWindow);
            UITestControlCollection collection = controls.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlCheckBox checkBox in collection)
                    if (checkBox.Id == controlName || checkBox.Name == controlName)
                        return checkBox;

            return null;
        }

        internal static HtmlButton GetButtonByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlButton controls = new HtmlButton(_browserWindow);
            UITestControlCollection collection = controls.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlButton button in collection)
                    if (button.Id == controlName || button.Name == controlName)
                        return button;

            return null;
        }

        internal static HtmlEdit GetTextBoxByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlEdit controls = new HtmlEdit(_browserWindow);
            UITestControlCollection collection = controls.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlEdit textBox in collection)
                    if (textBox.Id == controlName || textBox.Name == controlName)
                        return textBox;

            return null;
        }

        internal static HtmlRadioButton GetRadioButtonByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlRadioButton controls = new HtmlRadioButton(_browserWindow);
            UITestControlCollection collection = controls.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlRadioButton radioButton in collection)
                    if (radioButton.Id == controlName || radioButton.Name == controlName)
                        return radioButton;

            return null;
        }

        internal static HtmlLabel GetLabelByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlLabel controls = new HtmlLabel(_browserWindow);
            UITestControlCollection collection = controls.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlLabel label in collection)
                    if (label.Id == controlName || label.Name == controlName)
                        return label;

            return null;
        }

        internal static HtmlSpan GetSpanByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlSpan controls = new HtmlSpan(_browserWindow);
            UITestControlCollection collection = controls.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlSpan span in collection)
                    if (span.Id == controlName || span.Name == controlName)
                        return span;

            return null;
        }
    }
}
