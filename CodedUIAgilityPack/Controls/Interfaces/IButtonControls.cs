using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUIAgilityPack.Controls.Interfaces
{
    /// <summary>
    /// Interface representing Button control
    /// </summary>
    public interface IButtonControls
    {
        /// <summary>
        /// Return enabled property
        /// </summary>
        /// <returns>Boolean</returns>
        bool IsEnabled { get; }

        /// <summary>
        /// Return the css class name
        /// </summary>
        string GetCssClassName { get; }

        /// <summary>
        /// Mouse click on the button
        /// </summary>
        void Click();

        /// <summary>
        /// Return the complete object
        /// </summary>
        HtmlButton Button { get; }
    }
}
