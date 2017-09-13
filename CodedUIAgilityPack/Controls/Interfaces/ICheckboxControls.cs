namespace CodedUIAgilityPack.Controls.Interfaces
{
    public interface ICheckboxControls
    {
        bool IsChecked();

        bool IsEnabled();

        void Check();

        void Uncheck();

        string GetCssClassName();
    }
}
