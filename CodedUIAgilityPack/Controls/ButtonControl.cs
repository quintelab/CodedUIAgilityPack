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
        /// Create new instance of button control - This constructor should be used for Button without ID
        /// Use the method FindButtonByClassName to localizate your button
        /// </summary>
        public ButtonControl() : base(string.Empty)
        {

        }

        /// <summary>
        /// Create a new button control
        /// </summary>
        /// <param name="controlName">ID Property (ID that is render on the browser)</param>
        public ButtonControl(string controlName) : base(controlName)
        {
            if (string.IsNullOrEmpty(controlName))
                throw new Exception("Control name is null or empty!");

            Button = LoadPageControls.GetButton(Browse.BrowserWindow, SearchBy.ID, controlName);

            if (Button == null)
                throw new Exception("Button not found!");
        }

        /// <summary>
        /// Localizate the button based on the css class name
        /// </summary>
        /// <param name="className">CSS class name</param>
        public void FindButtonByClassName(string className)
        {
            if (string.IsNullOrEmpty(className))
                throw new Exception("Class name is null or empty!");

            Button = LoadPageControls.GetButton(Browse.BrowserWindow, SearchBy.ClassName, className);

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
