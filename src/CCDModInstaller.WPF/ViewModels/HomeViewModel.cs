using CCDModInstaller.WPF.Commands;
using CCDModInstaller.WPF.States.Archiver;
using CCDModInstaller.WPF.States.DialogServices;
using CCDModInstaller.WPF.States.DirectoryServices;
using System.Windows.Input;

namespace CCDModInstaller.WPF.ViewModels
{
    class HomeViewModel : ViewModelBase
    {
        public HomeViewModel(IDialogService dialogService, IArchiver archiver, IDirectoryService dirService)
        {
            ShowDialogCommand = new ShowDialogCommand(dialogService, this);
            InstallCommand = new InstallCommand(archiver, dirService, this);
        }

        private string _folderPath;

        public string FolderPath
        {
            get => _folderPath;
            set
            {
                Set(ref _folderPath, value);
                OnPropertyChanged(nameof(CanInstall));
            }
        }

        private string _filePath;

        public string FilePath
        {
            get => _filePath;
            set
            {
                Set(ref _filePath, value);
                OnPropertyChanged(nameof(CanInstall));
            }
        }

        public bool CanInstall => !string.IsNullOrEmpty(FilePath) && !string.IsNullOrEmpty(FolderPath);

        public ICommand ShowDialogCommand { get; }
        
        public ICommand InstallCommand { get; }
    }
}
