using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUIAgilityPack.Controls.Interfaces
{
    /// <summary>
    /// Interface representing Checkbox control
    /// </summary>
    public interface ICheckboxControls
    {
        /// <summary>
        /// Localizate the checkbox based on the css class name
        /// </summary>
        /// <param name="className">CSS class name</param>
        void FindCheckBoxByClassName(string className);

        /// <summary>
        /// Return if checkbox is checked
        /// </summary>
        bool IsChecked { get; }

        /// <summary>
        /// Return enabled property
        /// </summary>
        bool IsEnabled { get; }

        /// <summary>
        /// Click on the checkbox and change the status to checked
        /// </summary>
        void Check();

        /// <summary>
        /// Click on the checkbox and change the status to unchecked
        /// </summary>
        void Uncheck();

        /// <summary>
        /// Return the css class name
        /// </summary>
        string GetCssClassName { get; }

        /// <summary>
        /// Return the complete object
        /// </summary>
        HtmlCheckBox CheckBox { get; }
    }
}
