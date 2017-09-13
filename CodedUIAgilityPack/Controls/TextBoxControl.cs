using CodedUIAgilityPack.Controls.Interfaces;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;

namespace CodedUIAgilityPack.Controls
{
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
        /// Return the Css class name
        /// </summary>
        /// <returns></returns>
        public string GetCssClassName()
        {
            HtmlEdit control = LoadPageControls.GetTextBoxByID(Browse.BrowserWindow, _controlName);
            return control.Class;
        }

        /// <summary>
        /// Set the property Text
        /// </summary>
        /// <param name="text">Value</param>
        public void SetText(string text)
        {
            HtmlEdit control = LoadPageControls.GetTextBoxByID(Browse.BrowserWindow, _controlName);
            control.Text = text;
        }

        /// <summary>
        /// Get the property Text
        /// </summary>
        /// <returns></returns>
        public string GetText()
        {
            HtmlEdit control = LoadPageControls.GetTextBoxByID(Browse.BrowserWindow, _controlName);
            return control.Text;
        }

        /// <summary>
        /// Return the complete object
        /// </summary>
        public HtmlEdit RadioButton
        {
            get
            {
                return LoadPageControls.GetTextBoxByID(Browse.BrowserWindow, _controlName);
            }
        }
    }
}
