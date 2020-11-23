using AsssemblyBrowserApp.ViewModel.Command;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace AsssemblyBrowserApp.ViewModel
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        private Assembly assembly = null;
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

            }
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
