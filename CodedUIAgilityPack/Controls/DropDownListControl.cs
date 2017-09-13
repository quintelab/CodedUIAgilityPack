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
        private List<ListOptions> _dropDownListOptions;

        public List<ListOptions> DropDownListOptions
        {
            get
            {
                return _dropDownListOptions;
            }
        }

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
            _dropDownListOptions = new List<ListOptions>();
        }

        /// <summary>
        /// Add a item to the DropDownList.
        /// </summary>
        /// <param name="option">Object that represents a DropDownList Item, contains value and description</param>
        public void AddItem(ListOptions option)
        {
            _dropDownListOptions.Add(option);
        }

        /// <summary>
        /// Add a item to the DropDownList.
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="description">Description</param>
        public void AddItem(string value, string description)
        {
            _dropDownListOptions.Add(new ListOptions(value, description));
        }

        /// <summary>
        /// Remove all DropDownList items.
        /// </summary>
        public void Clear()
        {
            _dropDownListOptions = new List<ListOptions>();
        }

        /// <summary>
        /// Select one of the DropDownList options. This method will execute a click on the DropDownList.
        /// </summary>
        /// <param name="dropDownItem">Object that represents a DropDownList Option, contains value and description</param>
        public void Select(ListOptions dropDownItem)
        {
            if (!_dropDownListOptions.Contains(dropDownItem))
                throw new Exception("DropDownList item not found!");

            Select(dropDownItem.Value);
        }

        /// <summary>
        /// Select one of the DropDownList options. This method will execute a click on the DropDownList.
        /// </summary>
        /// <param name="dropDownValue">DropDown value</param>
        public void Select(string dropDownValue)
        {
            if (_dropDownListOptions.Find(x => x.Value == dropDownValue) == null)
                throw new Exception("DropDownList item not found!");

            HtmlComboBox dropDown = LoadPageControls.GetComboboxByID(Browse.BrowserWindow, _controlName);
            UITestControlCollection items = dropDown.Items;

            foreach (HtmlListItem item in items)
            {
                if (item.ValueAttribute == dropDownValue)
                {
                    dropDown.SelectedItem = item.InnerText;
                    break;
                }
            }
        }

        /// <summary>
        /// Return the selected RadioButton item. 
        /// </summary>
        /// <returns></returns>
        public ListOptions SelectedItem()
        {
            HtmlComboBox dropDown = LoadPageControls.GetComboboxByID(Browse.BrowserWindow, _controlName);
            return _dropDownListOptions.SingleOrDefault(d => d.Description == dropDown.SelectedItem.ToString());
        }

        /// <summary>
        /// Return the Css class name
        /// </summary>
        /// <returns></returns>
        public string GetCssClassName()
        {
            HtmlComboBox dropDown = LoadPageControls.GetComboboxByID(Browse.BrowserWindow, _controlName);
            return dropDown.Class;
        }

        public int NumberOfItems
        {
            get
            {
                HtmlComboBox dropDown = LoadPageControls.GetComboboxByID(Browse.BrowserWindow, _controlName);
                return dropDown.GetChildren().Count;
            }
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
