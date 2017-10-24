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
        /// Create new instance of Span control - This constructor should be used for Span without ID
        /// Use the method FindSpanByClassName to localizate your Span
        /// </summary>
        public SpanControl() : base(string.Empty)
        {

        }

        /// <summary>
        /// Create a new Span control
        /// </summary>
        /// <param name="controlName">ID Property (ID that is render on the browser)</param>
        public SpanControl(string controlName) : base(controlName)
        {
            Span = LoadPageControls.GetSpan(Browse.BrowserWindow, SearchBy.ID, controlName);

            if (Span == null)
                throw new Exception("Span not found!");
        }

        /// <summary>
        /// Localizate the span based on the css class name
        /// </summary>
        /// <param name="className">CSS class name</param>
        public void FindSpanByClassName(string className)
        {
            if (string.IsNullOrEmpty(className))
                throw new Exception("Class name is null or empty!");

            Span = LoadPageControls.GetSpan(Browse.BrowserWindow, SearchBy.ClassName, className);

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
