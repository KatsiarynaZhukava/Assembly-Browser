namespace AsssemblyBrowserApp.ViewModel
{
    interface IOpenDialogService
    {
        string FilePath { get; set; }
        bool OpenFileDialog();
    }
}
