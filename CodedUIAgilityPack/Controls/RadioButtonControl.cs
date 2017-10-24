using CodedUIAgilityPack.Controls.Interfaces;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodedUIAgilityPack.Controls
{
    /// <summary>
    /// Class representing RadioButton control
    /// </summary>
    public class RadioButtonControl : BaseControl, IRadioButtonControls
    {
        /// <summary>
        /// Create new instance of RadioButton control - This constructor should be used for RadioButton without ID
        /// Use the method FindRadioButtonByClassName to localizate your RadioButton
        /// </summary>
        public RadioButtonControl() : base(string.Empty)
        {

        }

        /// <summary>
        /// Create a new RadioButton control
        /// </summary>
        /// <param name="controlName">ID Property (ID that is render on the browser)</param>
        public RadioButtonControl(string controlName) : base(controlName)
        {
            RadioButton = LoadPageControls.GetRadioButton(Browse.BrowserWindow, SearchBy.ID, controlName);

            if (RadioButton == null)
                throw new Exception("RadioButton not found!");
        }

        /// <summary>
        /// Localizate the radiobutton based on the css class name
        /// </summary>
        /// <param name="className">CSS class name</param>
        public void FindRadioButtonByClassName(string className)
        {
            if (string.IsNullOrEmpty(className))
                throw new Exception("Class name is null or empty!");

            RadioButton = LoadPageControls.GetRadioButton(Browse.BrowserWindow, SearchBy.ClassName, className);

            if (RadioButton == null)
                throw new Exception("RadioButton not found!");
        }

        /// <summary>
        /// Select one of the RadioButtom items based on its ID. This method will execute a click on the radiobutton.
        /// </summary>
        /// <param name="radioButtonItemName">RadioButton Item name, ID that is render on the browser</param>
        public void SelectById(string radioButtonItemName)
        {
            foreach (HtmlControl item in GetRadioButtonItems)
                if (item.Id == radioButtonItemName)
                {
                    Mouse.Click(item);
                    break;
                }
        }

        /// <summary>
        /// Select one of the RadioButtom items based on its Value. This method will execute a click on the radiobutton.
        /// </summary>
        /// <param name="radioButtonItemValue">RadioButton Item value</param>
        public void SelectByValue(string radioButtonItemValue)
        {
            foreach (HtmlControl item in GetRadioButtonItems)
                if (item.ValueAttribute == radioButtonItemValue)
                {
                    Mouse.Click(item);
                    break;
                }
        }

        /// <summary>
        /// Return all RadioButton items
        /// </summary>
        /// <returns></returns>
        public List<ListOptions> GetChildren()
        {
            return GetRadioButtonItems.Select(item => new ListOptions(((HtmlControl)item).Id,
                ((HtmlControl)item).ValueAttribute, ((HtmlControl)item).InnerText)).ToList();
        }

        /// <summary>
        /// Return the selected RadioButton item. 
        /// Throw an Exception if there is no item selected.
        /// </summary>
        /// <returns>RadioButton item</returns>
        public ListOptions SelectedItem
        {
            get
            {
                foreach (HtmlControl item in GetRadioButtonItems)
                {
                    if (item.State.HasFlag(ControlStates.Checked))
                        return new ListOptions(item.Id, item.ValueAttribute, item.InnerText);
                }

                return null;
            }
        }

        /// <summary>
        /// Return the complete object
        /// </summary>
        public HtmlRadioButton RadioButton
        {
            get; private set;
        }

        /// <summary>
        /// Get the number of items
        /// </summary>
        public int NumberOfItems
        {
            get
            {
                return GetChildren().Count;
            }
        }

        private UITestControlCollection GetRadioButtonItems
        {
            get
            {
                return RadioButton.Group;
            }
        }
    }
}
