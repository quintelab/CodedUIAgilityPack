using CodedUIAgilityPack.Controls.Interfaces;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;

namespace CodedUIAgilityPack.Controls
{
    /// <summary>
    /// Class representing TextBox control
    /// </summary>
    public class TextBoxControl : BaseControl, ITextBoxControls
    {
        /// <summary>
        /// Create new instance of TextBox control - This constructor should be used for TextBox without ID
        /// Use the method FindTextBoxByClassName to localizate your TextBox
        /// </summary>
        public TextBoxControl() : base(string.Empty)
        {

        }

        /// <summary>
        /// Create a new textbox control
        /// </summary>
        /// <param name="controlName"></param>
        public TextBoxControl(string controlName) : base(controlName)
        {
            TextBox = LoadPageControls.GetTextBox(Browse.BrowserWindow, SearchBy.ID, controlName);

            if (TextBox == null)
                throw new Exception("TextBox not found!");
        }

        /// <summary>
        /// Localizate the textbox based on the css class name
        /// </summary>
        /// <param name="className">CSS class name</param>
        public void FindTextBoxByClassName(string className)
        {
            if (string.IsNullOrEmpty(className))
                throw new Exception("Class name is null or empty!");

            TextBox = LoadPageControls.GetTextBox(Browse.BrowserWindow, SearchBy.ClassName, className);

            if (TextBox == null)
                throw new Exception("TextBox not found!");
        }

        /// <summary>
        /// Get the Css class name
        /// </summary>
        public string GetCssClassName
        {
            get
            {
                return TextBox.Class;
            }
        }

        /// <summary>
        /// Set the TextBox value
        /// </summary>
        /// <param name="text">Value</param>
        public void SetText(string text)
        {
            TextBox.Text = text;
        }

        /// <summary>
        /// Return the TextBox value
        /// </summary>
        public string GetText
        {
            get
            {
                return TextBox.Text;
            }
        }

        /// <summary>
        /// Return the complete object
        /// </summary>
        public HtmlEdit TextBox
        {
            get; private set;
        }
    }
}
