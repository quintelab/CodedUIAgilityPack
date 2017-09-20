using CodedUIAgilityPack.Controls.Interfaces;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;

namespace CodedUIAgilityPack.Controls
{
    /// <summary>
    /// Class representing TextBox control
    /// </summary>
    public class TextBoxControl : ITextBoxControls
    {
        private string _controlName;

        /// <summary>
        /// Create a new textbox control
        /// </summary>
        /// <param name="controlName"></param>
        public TextBoxControl(string controlName)
        {
            if (Browse.BrowserWindow == null)
            {
                throw new Exception("BrowserWindow is null!");
            }

            _controlName = controlName;
        }

        /// <summary>
        /// Get the Css class name
        /// </summary>
        public string GetCssClassName
        {
            get
            {
                HtmlEdit control = LoadPageControls.GetTextBoxByID(Browse.BrowserWindow, _controlName);
                return control.Class;
            }
        }

        /// <summary>
        /// Set the TextBox value
        /// </summary>
        /// <param name="text">Value</param>
        public void SetText(string text)
        {
            HtmlEdit control = LoadPageControls.GetTextBoxByID(Browse.BrowserWindow, _controlName);
            control.Text = text;
        }

        /// <summary>
        /// Return the TextBox value
        /// </summary>
        public string GetText
        {
            get
            {
                HtmlEdit control = LoadPageControls.GetTextBoxByID(Browse.BrowserWindow, _controlName);
                return control.Text;
            }
        }

        /// <summary>
        /// Return the complete object
        /// </summary>
        public HtmlEdit TextBox
        {
            get
            {
                return LoadPageControls.GetTextBoxByID(Browse.BrowserWindow, _controlName);
            }
        }
    }
}
