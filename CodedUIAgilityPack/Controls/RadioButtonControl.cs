using CodedUIAgilityPack.Controls.Interfaces;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;

namespace CodedUIAgilityPack.Controls
{
    public class RadioButtonControl : IRadioButtonControls
    {
        private string _controlName;
        private List<ListOptions> _radioButtonOptions;
        public List<ListOptions> RadioButtonItems
        {
            get
            {
                return _radioButtonOptions;
            }
        }

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
            _radioButtonOptions = new List<ListOptions>();
        }

        /// <summary>
        /// Add a RadioButton item.
        /// </summary>
        /// <param name="option">Object that represents a RadioButtom Item, contains name, value and description</param>
        public void AddItem(ListOptions option)
        {
            if (string.IsNullOrEmpty(option.Name))
                throw new Exception("Name is empty!");

            _radioButtonOptions.Add(option);
        }

        /// <summary>
        /// Add a RadioButton item.
        /// </summary>
        /// <param name="name">ID Property</param>
        /// <param name="value">Value</param>
        /// <param name="description">Description</param>
        public void AddItem(string name, string value, string description)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Name is empty!");

            _radioButtonOptions.Add(new ListOptions(name, value, description));
        }

        /// <summary>
        /// Remove all RadioButton items.
        /// </summary>
        public void Clear()
        {
            _radioButtonOptions = new List<ListOptions>();
        }

        /// <summary>
        /// Select one of the RadioButtom items. This method will execute a click on the radiobutton.
        /// </summary>
        /// <param name="radioButtonItem">Object that represents a RadioButtom Item, contains name, value and description</param>
        public void Select(ListOptions radioButtonItem)
        {
            if (!_radioButtonOptions.Contains(radioButtonItem))
                throw new Exception("Radio button item not found!");

            Select(radioButtonItem.Name);
        }

        /// <summary>
        /// Select one of the RadioButtom items. This method will execute a click on the radiobutton.
        /// </summary>
        /// <param name="radioButtonName">RadioButton Item name, ID that is render on the browser</param>
        public void Select(string radioButtonName)
        {
            if (_radioButtonOptions.Find(x => x.Name == radioButtonName) == null)
                throw new Exception("Radio button item not found!");

            Mouse.Click(LoadPageControls.GetControlByID(Browse.BrowserWindow, radioButtonName));
        }

        /// <summary>
        /// Return the selected RadioButton item. 
        /// Throw an Exception if there is no item selected.
        /// </summary>
        /// <returns></returns>
        public ListOptions SelectedItem()
        {
            foreach (var item in _radioButtonOptions)
            {
                UITestControl control = LoadPageControls.GetControlByID(Browse.BrowserWindow, item.Name);

                if (control.State.HasFlag(ControlStates.Checked))
                    return item;
            }

            throw new Exception("There is no RadioButton item selected.");
        }

        /// <summary>
        /// Return the complete object
        /// </summary>
        public UITestControl RadioButton
        {
            get
            {
                return LoadPageControls.GetControlByID(Browse.BrowserWindow, _controlName);
            }
        }
    }
}
