using CodedUIAgilityPack.Controls.Interfaces;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;

namespace CodedUIAgilityPack.Controls
{
    /// <summary>
    /// Class representing Checkbox control
    /// </summary>
    public class CheckboxControl : BaseControl, ICheckboxControls
    {
        /// <summary>
        /// Create new instance of checkbox control - This constructor should be used for CheckBox without ID
        /// Use the method FindCheckBoxByClassName to localizate your checkbox
        /// </summary>
        public CheckboxControl() : base(string.Empty)
        {

        }

        /// <summary>
        /// Create a new checkbox control
        /// </summary>
        /// <param name="controlName">ID Property (ID that is render on the browser)</param>
        public CheckboxControl(string controlName) : base(controlName)
        {
            CheckBox = LoadPageControls.GetCheckBox(Browse.BrowserWindow, SearchBy.ID, controlName);

            if (CheckBox == null)
                throw new Exception("CheckBox not found!");
        }

        /// <summary>
        /// Localizate the checkbox based on the css class name
        /// </summary>
        /// <param name="className">CSS class name</param>
        public void FindCheckBoxByClassName(string className)
        {
            if (string.IsNullOrEmpty(className))
                throw new Exception("Class name is null or empty!");

            CheckBox = LoadPageControls.GetCheckBox(Browse.BrowserWindow, SearchBy.ClassName, className);

            if (CheckBox == null)
                throw new Exception("CheckBox not found!");
        }

        /// <summary>
        /// Return if checkbox is checked
        /// </summary>
        public bool IsChecked
        {
            get
            {
                return CheckBox.State.HasFlag(ControlStates.Checked);
            }
        }

        /// <summary>
        /// Return enabled property
        /// </summary>
        public bool IsEnabled
        {
            get
            {
                return CheckBox.Enabled;
            }
        }

        /// <summary>
        /// Click on the checkbox and change the status to checked
        /// </summary>
        public void Check()
        {
            if (!CheckBox.State.HasFlag(ControlStates.Checked))
                Mouse.Click(CheckBox);
        }

        /// <summary>
        /// Click on the checkbox and change the status to unchecked
        /// </summary>
        public void Uncheck()
        {
            if (CheckBox.State.HasFlag(ControlStates.Checked))
                Mouse.Click(CheckBox);
        }

        /// <summary>
        /// Return the css class name
        /// </summary>
        public string GetCssClassName
        {
            get
            {
                return CheckBox.Class;
            }
        }

        /// <summary>
        /// Return the complete object
        /// </summary>
        public HtmlCheckBox CheckBox
        {
            get; private set;
        }
    }
}
