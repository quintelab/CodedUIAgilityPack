using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Collections.Generic;

namespace CodedUIAgilityPack.Controls.Interfaces
{
    /// <summary>
    /// Interface representing RadioButton control
    /// </summary>
    public interface IRadioButtonControls
    {
        /// <summary>
        /// Localizate the radiobutton based on the css class name
        /// </summary>
        /// <param name="className">CSS class name</param>
        void FindRadioButtonByClassName(string className);

        /// <summary>
        /// Select one of the RadioButtom items, based on its ID. This method will execute a click on the radiobutton.
        /// </summary>
        /// <param name="radioButtonItemName">RadioButton Item name, ID that is render on the browser</param>
        void SelectById(string radioButtonItemName);

        /// <summary>
        /// Select one of the RadioButtom items, based on its Value. This method will execute a click on the radiobutton.
        /// </summary>
        /// <param name="radioButtonItemName">RadioButton Item value</param>
        void SelectByValue(string radioButtonItemName);

        /// <summary>
        /// Return the selected RadioButton item. 
        /// </summary>
        ListOptions SelectedItem { get; }

        /// <summary>
        /// Get the number of items
        /// </summary>
        int NumberOfItems { get; }

        /// <summary>
        /// Return all RadioButton items
        /// </summary>
        /// <returns></returns>
        List<ListOptions> GetChildren();

        /// <summary>
        /// Return the complete object
        /// </summary>
        HtmlRadioButton RadioButton { get; }
    }
}
