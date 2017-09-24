using CodedUIAgilityPack.Controls.Interfaces;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;

namespace CodedUIAgilityPack.Controls
{
    /// <summary>
    /// Class representing Button control
    /// </summary>
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
        /// Mouse click on the button
        /// </summary>
        public void Click()
        {
            Mouse.Click(LoadPageControls.GetButtonByID(Browse.BrowserWindow, _controlName));
        }

        /// <summary>
        /// Return the css class name
        /// </summary>
        /// <returns>Return string</returns>
        public string GetCssClassName
        {
            get
            {
                HtmlButton control = LoadPageControls.GetButtonByID(Browse.BrowserWindow, _controlName);
                return control.Class;
            }
        }

        /// <summary>
        /// Return enabled property
        /// </summary>
        /// <returns>Boolean</returns>
        public bool IsEnabled
        {
            get
            {
                HtmlButton control = LoadPageControls.GetButtonByID(Browse.BrowserWindow, _controlName);
                return control.Enabled;
            }
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
