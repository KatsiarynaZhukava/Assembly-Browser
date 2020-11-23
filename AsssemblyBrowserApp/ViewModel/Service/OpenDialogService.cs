using Microsoft.Win32;

namespace AsssemblyBrowserApp.ViewModel
{
    class OpenDialogService : IOpenDialogService
    {
        public string FilePath { get; set; }

        public bool OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                return true;
            }
            return false;
        }

            /*public void ShowMessage(string message)
            {
                MessageBox.Show(message);
            }*/
    }
}
