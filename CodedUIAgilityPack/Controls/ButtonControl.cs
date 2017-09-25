using CodedUIAgilityPack.Controls.Interfaces;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;

namespace CodedUIAgilityPack.Controls
{
    /// <summary>
    /// Class representing Button control
    /// </summary>
    public class ButtonControl : BaseControl, IButtonControls
    {
        /// <summary>
        /// Create a new button control
        /// </summary>
        /// <param name="controlName">ID Property (ID that is render on the browser)</param>
        public ButtonControl(string controlName) : base(controlName)
        {
            Button = LoadPageControls.GetButtonByID(Browse.BrowserWindow, controlName);

            if (Button == null)
                throw new Exception("Button not found!");
        }

        /// <summary>
        /// Mouse click on the button
        /// </summary>
        public void Click()
        {
            Mouse.Click(Button);
        }

        /// <summary>
        /// Return the css class name
        /// </summary>
        /// <returns>Return string</returns>
        public string GetCssClassName
        {
            get
            {
                return Button.Class;
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
                return Button.Enabled;
            }
        }

        /// <summary>
        /// Return the complete object
        /// </summary>
        public HtmlButton Button
        {
            get; private set;
        }
    }
}
