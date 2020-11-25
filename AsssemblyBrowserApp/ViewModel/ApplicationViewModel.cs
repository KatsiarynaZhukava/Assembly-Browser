using AsssemblyBrowserApp.ViewModel.Command;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AssemblyBrowserLibrary;

namespace AsssemblyBrowserApp.ViewModel
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        private AssemblyData assembly = null;
        private OpenDialogService dialogService = new OpenDialogService();
        private DataSource dataSource = new DataSource();

        public event PropertyChangedEventHandler PropertyChanged;
        public RelayCommand GetAssemblyCommand {get; set;}

        public ApplicationViewModel()
        {
            GetAssemblyCommand = new RelayCommand(o => GetAssembly());
        }

        private void GetAssembly()
        {
            if (dialogService.OpenFileDialog())
            {
                assembly = dataSource.GetAssembly(dialogService.FilePath);
                int i = 0;
            }
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
