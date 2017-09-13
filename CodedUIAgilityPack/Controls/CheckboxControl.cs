using CodedUIAgilityPack.Controls.Interfaces;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;

namespace CodedUIAgilityPack.Controls
{
    public class CheckboxControl : ICheckboxControls
    {
        private string _controlName;

        /// <summary>
        /// Create a new checkbox control
        /// </summary>
        /// <param name="controlName">ID Property (ID that is render on the browser)</param>
        public CheckboxControl(string controlName)
        {
            if (Browse.BrowserWindow == null)
            {
                throw new Exception("BrowserWindow is null!");
            }

            _controlName = controlName;
        }

        /// <summary>
        /// Return true if checkbox is checked
        /// </summary>
        /// <returns></returns>
        public bool IsChecked()
        {
            UITestControl control = LoadPageControls.GetControlByID(Browse.BrowserWindow, _controlName);
            return control.State.HasFlag(ControlStates.Checked);
        }

        /// <summary>
        /// Return true if checbox is Enabled
        /// </summary>
        /// <returns></returns>
        public bool IsEnabled()
        {
            UITestControl control = LoadPageControls.GetControlByID(Browse.BrowserWindow, _controlName);
            return control.Enabled;
        }

        /// <summary>
        /// Click on the checkbox and change the status to checked
        /// </summary>
        public void Check()
        {
            UITestControl control = LoadPageControls.GetControlByID(Browse.BrowserWindow, _controlName);

            if (!control.State.HasFlag(ControlStates.Checked))
                Mouse.Click(control);
        }

        /// <summary>
        /// Click on the checkbox and change the status to unchecked
        /// </summary>
        public void Uncheck()
        {
            UITestControl control = LoadPageControls.GetControlByID(Browse.BrowserWindow, _controlName);

            if (control.State.HasFlag(ControlStates.Checked))
                Mouse.Click(control);
        }

        /// <summary>
        /// Return the Css class name
        /// </summary>
        /// <returns></returns>
        public string GetCssClassName()
        {
            HtmlCheckBox control = LoadPageControls.GetCheckBoxByID(Browse.BrowserWindow, _controlName);
            return control.Class;
        }

        /// <summary>
        /// Return the complete object
        /// </summary>
        public HtmlCheckBox CheckBox
        {
            get
            {
                return LoadPageControls.GetCheckBoxByID(Browse.BrowserWindow, _controlName);
            }
        }
    }
}
