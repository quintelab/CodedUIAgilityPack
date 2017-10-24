using CodedUIAgilityPack.Controls.Interfaces;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;

namespace CodedUIAgilityPack.Controls
{
    /// <summary>
    /// Class representing Label control
    /// </summary>
    public class LabelControl : BaseControl, ILabelControls
    {
        /// <summary>
        /// Create new instance of Label control - This constructor should be used for Label without ID
        /// Use the method FindLabelByClassName to localizate your label
        /// </summary>
        public LabelControl() : base(string.Empty)
        {

        }

        /// <summary>
        /// Create a new label control
        /// </summary>
        /// <param name="controlName">ID Property (ID that is render on the browser)</param>
        public LabelControl(string controlName) : base(controlName)
        {
            Label = LoadPageControls.GetLabel(Browse.BrowserWindow, SearchBy.ID, controlName);

            if (Label == null)
                throw new Exception("Label not found!");
        }

        /// <summary>
        /// Localizate the label based on the css class name
        /// </summary>
        /// <param name="className">CSS class name</param>
        public void FindLabelByClassName(string className)
        {
            if (string.IsNullOrEmpty(className))
                throw new Exception("Class name is null or empty!");

            Label = LoadPageControls.GetLabel(Browse.BrowserWindow, SearchBy.ClassName, className);

            if (Label == null)
                throw new Exception("Label not found!");
        }

        /// <summary>
        /// Return label's value
        /// </summary>
        public string GetText
        {
            get
            {
                return Label.DisplayText;
            }
        }

        /// <summary>
        /// Get the Css class name
        /// </summary>
        public string GetCssClassName
        {
            get
            {
                return Label.Class;
            }
        }

        /// <summary>
        /// Return the complete object
        /// </summary>
        public HtmlLabel Label
        {
            get; private set;
        }

        /// <summary>
        /// Mouse click on the label
        /// </summary>
        public void Click()
        {
            Mouse.Click(Label);
        }
    }
}
