using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUIAgilityPack.Controls.Interfaces
{
    /// <summary>
    /// Interface representing Span controls
    /// </summary>
    public interface ISpanControls
    {
        /// <summary>
        /// Localizate the span based on the css class name
        /// </summary>
        /// <param name="className">CSS class name</param>
        void FindSpanByClassName(string className);

        /// <summary>
        /// Return span's value
        /// </summary>
        string GetText { get; }

        /// <summary>
        /// Get the Css class name
        /// </summary>
        string GetCssClassName { get; }

        /// <summary>
        /// Mouse click on the spam
        /// </summary>
        void Click();

        /// <summary>
        /// Return the complete object
        /// </summary>
        HtmlSpan Span { get; }
    }
}
