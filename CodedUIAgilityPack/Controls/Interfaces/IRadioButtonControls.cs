namespace CodedUIAgilityPack.Controls.Interfaces
{
    public interface IRadioButtonControls : IControls
    {
        void AddItem(ListOptions option);

        void AddItem(string name, string value, string description);

        void Select(ListOptions radioButtonItem);

        void Select(string radioButtonName);

        ListOptions SelectedItem();
    }
}
