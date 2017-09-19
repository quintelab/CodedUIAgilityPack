using CodedUIAgilityPack.Controls.Interfaces;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodedUIAgilityPack.Controls
{
    public class DropDownListControl : IDropDownListControls
    {
        private string _controlName;

        /// <summary>
        /// Create a new 'select' control
        /// </summary>
        /// <param name="controlName">ID Property (ID that is render on the browser)</param>
        public DropDownListControl(string controlName)
        {
            if (Browse.BrowserWindow == null)
            {
                throw new Exception("BrowserWindow is null!");
            }

            _controlName = controlName;
        }

        /// <summary>
        /// Select one of the DropDownList options. This method will execute a click on the DropDownList.
        /// </summary>
        /// <param name="dropDownValue">DropDown value</param>
        public void Select(string dropDownValue)
        {
            HtmlComboBox dropDown = LoadPageControls.GetComboboxByID(Browse.BrowserWindow, _controlName);

            foreach (HtmlListItem item in dropDown.Items)
            {
                if (item.ValueAttribute == dropDownValue)
                {
                    dropDown.SelectedItem = item.InnerText;
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
                HtmlComboBox dropDown = LoadPageControls.GetComboboxByID(Browse.BrowserWindow, _controlName);
                return ((HtmlListItem)dropDown.Items[dropDown.SelectedIndex]).ValueAttribute;
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
                HtmlComboBox dropDown = LoadPageControls.GetComboboxByID(Browse.BrowserWindow, _controlName);
                HtmlListItem item = (HtmlListItem)dropDown.Items[dropDown.SelectedIndex];
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
                HtmlComboBox dropDown = LoadPageControls.GetComboboxByID(Browse.BrowserWindow, _controlName);
                return dropDown.Class;
            }
        }

        /// <summary>
        /// Get the number of Items
        /// </summary>
        public int NumberOfItems
        {
            get
            {
                HtmlComboBox dropDown = LoadPageControls.GetComboboxByID(Browse.BrowserWindow, _controlName);
                return dropDown.GetChildren().Count;
            }
        }

        /// <summary>
        /// Return all DropDownList items
        /// </summary>
        /// <returns></returns>
        public List<ListOptions> GetChildren()
        {
            HtmlComboBox dropDown = LoadPageControls.GetComboboxByID(Browse.BrowserWindow, _controlName);
            UITestControlCollection collectionItems = dropDown.GetChildren();

            return collectionItems.Select(item => new ListOptions(((HtmlListItem)item).ValueAttribute, ((HtmlListItem)item).InnerText)).ToList();
        }

        /// <summary>
        /// Return the complete object
        /// </summary>
        public HtmlComboBox DropDownList
        {
            get
            {
                return LoadPageControls.GetComboboxByID(Browse.BrowserWindow, _controlName);
            }
        }
    }
}
