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
        /// Create a new textbox control
        /// </summary>
        /// <param name="controlName"></param>
        public TextBoxControl(string controlName) : base(controlName)
        {
            TextBox = LoadPageControls.GetTextBoxByID(Browse.BrowserWindow, controlName);

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
