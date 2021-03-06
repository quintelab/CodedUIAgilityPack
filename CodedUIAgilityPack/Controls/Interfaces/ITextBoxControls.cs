﻿using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUIAgilityPack.Controls.Interfaces
{
    /// <summary>
    /// Interface representing TextBox control
    /// </summary>
    public interface ITextBoxControls
    {
        /// <summary>
        /// Localizate the textbox based on the css class name
        /// </summary>
        /// <param name="className">CSS class name</param>
        void FindTextBoxByClassName(string className);

        /// <summary>
        /// Get the Css class name
        /// </summary>
        string GetCssClassName { get; }

        /// <summary>
        /// Set the TextBox value
        /// </summary>
        /// <param name="text">Value</param>
        void SetText(string text);

        /// <summary>
        /// Return the TextBox value
        /// </summary>
        string GetText { get; }

        /// <summary>
        /// Return the complete object
        /// </summary>
        HtmlEdit TextBox { get; }
    }
}
