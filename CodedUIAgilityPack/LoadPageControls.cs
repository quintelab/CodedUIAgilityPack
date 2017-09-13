using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUIAgilityPack
{
    public static class LoadPageControls
    {
        public static UITestControl GetControlByID(BrowserWindow _browserWindow, string controlName)
        {
            UITestControl control = new UITestControl(_browserWindow);
            control.TechnologyName = "Web";
            control.SearchProperties.Add(HtmlControl.PropertyNames.Id, controlName);

            return control;
        }

        public static HtmlComboBox GetComboboxByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlComboBox box = new HtmlComboBox(_browserWindow);
            UITestControlCollection collection = box.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlComboBox comboBox in collection)
                    if (comboBox.Id == controlName || comboBox.Name == controlName)
                        return comboBox;

            return null;
        }

        public static HtmlCheckBox GetCheckBoxByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlCheckBox checkBox = new HtmlCheckBox(_browserWindow);
            UITestControlCollection collection = checkBox.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlCheckBox check in collection)
                    if (check.Id == controlName || check.Name == controlName)
                        return check;

            return null;
        }

        public static HtmlButton GetButtonByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlButton button = new HtmlButton(_browserWindow);
            UITestControlCollection collection = button.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlButton btn in collection)
                    if (btn.Id == controlName || btn.Name == controlName)
                        return btn;

            return null;
        }

        public static HtmlEdit GetTextBoxByID(BrowserWindow _browserWindow, string controlName)
        {
            HtmlEdit textBox = new HtmlEdit(_browserWindow);
            UITestControlCollection collection = textBox.FindMatchingControls();

            if (collection.Count > 0)
                foreach (HtmlEdit text in collection)
                    if (text.Id == controlName || text.Name == controlName)
                        return text;

            return null;
        }
    }
}
