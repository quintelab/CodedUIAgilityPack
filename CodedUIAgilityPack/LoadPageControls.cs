using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUIAgilityPack
{
    internal static class LoadPageControls
    {
        internal static HtmlComboBox GetComboboxByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlComboBox box = new HtmlComboBox(_browserWindow);
            UITestControlCollection collection = box.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlComboBox comboBox in collection)
                    if (comboBox.Id == controlName || comboBox.Name == controlName)
                        return comboBox;

            return null;
        }

        internal static HtmlCheckBox GetCheckBoxByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlCheckBox checkBox = new HtmlCheckBox(_browserWindow);
            UITestControlCollection collection = checkBox.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlCheckBox check in collection)
                    if (check.Id == controlName || check.Name == controlName)
                        return check;

            return null;
        }

        internal static HtmlButton GetButtonByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlButton button = new HtmlButton(_browserWindow);
            UITestControlCollection collection = button.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlButton btn in collection)
                    if (btn.Id == controlName || btn.Name == controlName)
                        return btn;

            return null;
        }

        internal static HtmlEdit GetTextBoxByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlEdit textBox = new HtmlEdit(_browserWindow);
            UITestControlCollection collection = textBox.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlEdit text in collection)
                    if (text.Id == controlName || text.Name == controlName)
                        return text;

            return null;
        }

        internal static HtmlRadioButton GetRadioButtonByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlRadioButton radio = new HtmlRadioButton(_browserWindow);
            UITestControlCollection collection = radio.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlRadioButton radioButton in collection)
                    if (radioButton.Id == controlName || radioButton.Name == controlName)
                        return radioButton;

            return null;
        }
    }
}
