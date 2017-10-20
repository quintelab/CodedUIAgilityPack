using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUIAgilityPack.Controls.Interfaces
{
    /// <summary>
    /// Interface representing Button control
    /// </summary>
    public interface IButtonControls
    {
        /// <summary>
        /// Localizate the button based on the css class name
        /// </summary>
        /// <param name="className">CSS class name</param>
        void FindButtonByClassName(string className);

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
