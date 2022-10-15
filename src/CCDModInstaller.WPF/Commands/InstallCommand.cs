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

        private readonly IArchiver _archiver;

        private readonly IPlayerCarService _playerCarService;

        private readonly HomeViewModel _home;

        public InstallCommand(IArchiver archiver, IPlayerCarService playerCarsService, HomeViewModel home)
        {
            _archiver = archiver;
            _playerCarService = playerCarsService;
            _home = home;

            _home.PropertyChanged += HomeViewModel_PropertyChanged;
        }

        public bool CanExecute(object? parameter)
        {
            return _home.CanInstall;
        }

        public void Execute(object? parameter)
        {
            _archiver.Unrar(_home.FilePath, _home.FolderPath);
           _playerCarService.AddNewCar(_home.FolderPath);
        }

        private void HomeViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(HomeViewModel.CanInstall)) CanExecuteChanged?.Invoke(sender, e);
        }
    }
}
