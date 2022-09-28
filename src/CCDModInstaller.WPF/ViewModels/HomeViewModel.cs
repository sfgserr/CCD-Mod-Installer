using CCDModInstaller.WPF.Commands;
using CCDModInstaller.WPF.States.DialogService;
using System.Windows.Input;

namespace CCDModInstaller.WPF.ViewModels
{
    class HomeViewModel : ViewModelBase
    {
        public HomeViewModel(IDialogService dialogService)
        {
            ShowDialogCommand = new ShowDialogCommand(dialogService, this);
        }

        private string _path;

        public string Path
        {
            get => _path;
            set => Set(ref _path, value);
        }

        public ICommand ShowDialogCommand { get; } 
    }
}
