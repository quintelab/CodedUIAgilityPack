using CodedUIAgilityPack.Controls.Interfaces;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;

namespace CodedUIAgilityPack.Controls
{
    /// <summary>
    /// Class representing Span control
    /// </summary>
    public class SpanControl : BaseControl, ISpanControls
    {
        /// <summary>
        /// Create a new Span control
        /// </summary>
        public SpanControl(string controlName) : base(controlName)
        {
            Span = LoadPageControls.GetSpanByID(Browse.BrowserWindow, controlName);

            if (Span == null)
                throw new Exception("Span not found!");
        }

        /// <summary>
        /// Return Span's value
        /// </summary>
        public string GetText
        {
            get
            {
                return Span.DisplayText;
            }
        }

        /// <summary>
        /// Get the Css class name
        /// </summary>
        public string GetCssClassName
        {
            get
            {
                return Span.Class;
            }
        }

        /// <summary>
        /// Return the complete object
        /// </summary>
        public HtmlSpan Span
        {
            get; private set;
        }

        /// <summary>
        /// Mouse click on the Span
        /// </summary>
        public void Click()
        {
            Mouse.Click(Span);
        }
    }
}
