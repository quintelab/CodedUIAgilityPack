using CodedUIAgilityPack.Controls.Interfaces;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;

namespace CodedUIAgilityPack.Controls
{
    public class ButtonControl : IButtonControls
    {
        private string _controlName;

        /// <summary>
        /// Create a new button control
        /// </summary>
        /// <param name="controlName">ID Property (ID that is render on the browser)</param>
        public ButtonControl(string controlName)
        {
            if (Browse.BrowserWindow == null)
            {
                throw new Exception("BrowserWindow is null!");
            }

            _controlName = controlName;
        }

        /// <summary>
        /// Click on the button
        /// </summary>
        public void Click()
        {
            Mouse.Click(LoadPageControls.GetControlByID(Browse.BrowserWindow, _controlName));
        }

        /// <summary>
        /// Return the Css class name
        /// </summary>
        /// <returns></returns>
        public string GetCssClassName()
        {
            HtmlButton control = LoadPageControls.GetButtonByID(Browse.BrowserWindow, _controlName);
            return control.Class;
        }

        /// <summary>
        /// Return true if button is Enabled
        /// </summary>
        /// <returns></returns>
        public bool IsEnabled()
        {
            UITestControl control = LoadPageControls.GetControlByID(Browse.BrowserWindow, _controlName);
            return control.Enabled;
        }

        /// <summary>
        /// Return the complete object
        /// </summary>
        public HtmlButton Button
        {
            get
            {
                return LoadPageControls.GetButtonByID(Browse.BrowserWindow, _controlName);
            }
        }
    }
}
