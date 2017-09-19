using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System.Collections.Generic;

namespace CodedUIAgilityPack.Controls.Interfaces
{
    public interface IDropDownListControls
    {
        /// <summary>
        /// Select one of the DropDownList options. This method will execute a click on the DropDownList.
        /// </summary>
        /// <param name="dropDownValue">DropDown value</param>
        void Select(string dropDownValue);

        /// <summary>
        /// Get the selected value. 
        /// </summary>
        string SelectedValue { get; }

        /// <summary>
        /// Get the selected item. 
        /// </summary>
        ListOptions SelectedItem { get; }

        /// <summary>
        /// Get the Css class name
        /// </summary>
        string CssClassName { get; }

        /// <summary>
        /// Get the number of Items
        /// </summary>
        int NumberOfItems { get; }

        /// <summary>
        /// Return all DropDownList items
        /// </summary>
        /// <returns></returns>
        List<ListOptions> GetChildren();

        /// <summary>
        /// Return the complete object
        /// </summary>
        HtmlComboBox DropDownList { get; }
    }
}
