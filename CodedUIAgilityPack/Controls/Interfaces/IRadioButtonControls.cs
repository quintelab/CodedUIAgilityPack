using Microsoft.VisualStudio.TestTools.UITesting;

namespace CodedUIAgilityPack.Controls.Interfaces
{
    /// <summary>
    /// Interface representing RadioButton control
    /// </summary>
    public interface IRadioButtonControls
    {
        /// <summary>
        /// Add a RadioButton item.
        /// </summary>
        /// <param name="option">Object that represents a RadioButtom Item, contains name, value and description</param>
        void AddItem(ListOptions option);

        /// <summary>
        /// Add a RadioButton item.
        /// </summary>
        /// <param name="name">ID Property</param>
        /// <param name="value">Value</param>
        /// <param name="description">Description</param>
        void AddItem(string name, string value, string description);

        /// <summary>
        /// Select one of the RadioButtom items. This method will execute a click on the radiobutton.
        /// </summary>
        /// <param name="radioButtonItem">Object that represents a RadioButtom Item, contains name, value and description</param>
        void Select(ListOptions radioButtonItem);

        /// <summary>
        /// Select one of the RadioButtom items. This method will execute a click on the radiobutton.
        /// </summary>
        /// <param name="radioButtonName">RadioButton Item name, ID that is render on the browser</param>
        void Select(string radioButtonName);

        /// <summary>
        /// Return the selected RadioButton item. 
        /// </summary>
        /// <returns>RadioButton item</returns>
        ListOptions SelectedItem();

        /// <summary>
        /// Return the complete object
        /// </summary>
        UITestControl RadioButton { get; }
    }
}
