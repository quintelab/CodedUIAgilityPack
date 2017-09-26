using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUIAgilityPack.Controls.Interfaces
{
    /// <summary>
    /// Interface representing Span controls
    /// </summary>
    public interface ISpanControls
    {
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
