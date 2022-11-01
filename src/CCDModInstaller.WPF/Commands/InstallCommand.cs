using CCDModInstaller.WPF.Models;
using CCDModInstaller.WPF.States.Archiver;
using CCDModInstaller.WPF.States.PlayerCarsServices;
using CCDModInstaller.WPF.ViewModels;
using System;
using System.Windows.Input;

namespace CCDModInstaller.WPF.Commands
{
    class InstallCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        
        private readonly HomeViewModel _home;

        public InstallCommand(HomeViewModel home)
        {
            _home = home;
            _home.PropertyChanged += HomeViewModel_PropertyChanged;
        }

        public bool CanExecute(object? parameter)
        {
            return _home.CanInstall;
        }

        public void Execute(object? parameter)
        {
            Mod mod = new Mod(_home.FilePath);

            IArchiver archiver = new Archiver(mod);
            IPlayerCarService playerCarService = new PlayerCarService(mod);

            archiver.Unrar(_home.FilePath, _home.FolderPath);
            playerCarService.AddNewCar(_home.FolderPath);
        }

        private void HomeViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(HomeViewModel.CanInstall)) CanExecuteChanged?.Invoke(sender, e);
        }
    }
}
