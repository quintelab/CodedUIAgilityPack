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
    public class RadioButtonControl : IRadioButtonControls
    {
        private string _controlName;

        /// <summary>
        /// Create a new RadioButton control
        /// </summary>
        /// <param name="controlName">ID Property (ID that is render on the browser)</param>
        public RadioButtonControl(string controlName)
        {
            if (Browse.BrowserWindow == null)
            {
                throw new Exception("BrowserWindow is null!");
            }

            _controlName = controlName;
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
            get
            {
                return LoadPageControls.GetRadioButtonByID(Browse.BrowserWindow, _controlName);
            }
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
                HtmlRadioButton radioButton = LoadPageControls.GetRadioButtonByID(Browse.BrowserWindow, _controlName);
                return radioButton.Group;
            }
        }
    }
}
