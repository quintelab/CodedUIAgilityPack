using CodedUIAgilityPack.Controls.Interfaces;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodedUIAgilityPack.Controls
{
    /// <summary>
    /// Class representing DropDownList control
    /// </summary>
    public class DropDownListControl : BaseControl, IDropDownListControls
    {
        /// <summary>
        /// Create a new 'select' control
        /// </summary>
        /// <param name="controlName">ID Property (ID that is render on the browser)</param>
        public DropDownListControl(string controlName) : base(controlName)
        {
            DropDownList = LoadPageControls.GetComboboxByID(Browse.BrowserWindow, controlName);

            if (DropDownList == null)
                throw new Exception("DropDownList not found!");
        }

        /// <summary>
        /// Select one of the DropDownList options. This method will execute a click on the DropDownList.
        /// </summary>
        /// <param name="dropDownValue">DropDown value</param>
        public void Select(string dropDownValue)
        {
            foreach (HtmlListItem item in DropDownList.Items)
            {
                if (item.ValueAttribute == dropDownValue)
                {
                    DropDownList.SelectedItem = item.InnerText;
                    break;
                }
            }
        }

        /// <summary>
        /// Get the selected value. 
        /// </summary>
        /// <returns></returns>
        public string SelectedValue
        {
            get
            {
                return ((HtmlListItem)DropDownList.Items[DropDownList.SelectedIndex]).ValueAttribute;
            }
        }

        /// <summary>
        /// Get the selected item. 
        /// </summary>
        /// <returns></returns>
        public ListOptions SelectedItem
        {
            get
            {
                HtmlListItem item = (HtmlListItem)DropDownList.Items[DropDownList.SelectedIndex];
                return new ListOptions(item.ValueAttribute, item.InnerText);
            }
        }

        /// <summary>
        /// Get the Css class name
        /// </summary>
        /// <returns></returns>
        public string CssClassName
        {
            get
            {
                return DropDownList.Class;
            }
        }

        /// <summary>
        /// Get the number of Items
        /// </summary>
        public int NumberOfItems
        {
            get
            {
                return DropDownList.GetChildren().Count;
            }
        }

        /// <summary>
        /// Return all DropDownList items
        /// </summary>
        /// <returns></returns>
        public List<ListOptions> GetChildren()
        {
            UITestControlCollection collectionItems = DropDownList.GetChildren();

            return collectionItems.Select(item => new ListOptions(((HtmlListItem)item).ValueAttribute, ((HtmlListItem)item).InnerText)).ToList();
        }

        /// <summary>
        /// Return the complete object
        /// </summary>
        public HtmlComboBox DropDownList
        {
            get; private set;
        }
    }
}
