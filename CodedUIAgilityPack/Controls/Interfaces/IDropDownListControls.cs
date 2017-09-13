namespace CodedUIAgilityPack.Controls.Interfaces
{
    public interface IDropDownListControls : IControls
    {
        void AddItem(ListOptions option);

        void AddItem(string value, string description);

        void Select(ListOptions dropDownItem);

        void Select(string dropDownValue);

        ListOptions SelectedItem();
    }
}
