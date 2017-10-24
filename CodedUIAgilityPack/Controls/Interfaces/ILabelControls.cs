using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUIAgilityPack.Controls.Interfaces
{
    /// <summary>
    /// Interface representing Label controls
    /// </summary>
    public interface ILabelControls
    {
        /// <summary>
        /// Localizate the label based on the css class name
        /// </summary>
        /// <param name="className">CSS class name</param>
        void FindLabelByClassName(string className);

        /// <summary>
        /// Return label's value
        /// </summary>
        string GetText { get; }

        /// <summary>
        /// Get the Css class name
        /// </summary>
        string GetCssClassName { get; }

        /// <summary>
        /// Mouse click on the label
        /// </summary>
        void Click();

        /// <summary>
        /// Return the complete object
        /// </summary>
        HtmlLabel Label { get; }
    }
}
