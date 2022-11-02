using CCDModInstaller.WPF.States.Installers;
using CCDModInstaller.WPF.ViewModels;
using System;
using System.Windows.Input;

namespace CCDModInstaller.WPF.Commands
{
    class InstallCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        
        private readonly HomeViewModel _home;
        private readonly IInstaller _installer;

        public InstallCommand(HomeViewModel home, IInstaller installer)
        {
            _installer = installer;
            _home = home;
            _home.PropertyChanged += HomeViewModel_PropertyChanged;
        }

        public bool CanExecute(object? parameter)
        {
            return _home.CanInstall;
        }

        public void Execute(object? parameter)
        {
            _installer.Install(_home.FilePath, _home.FolderPath);
        }

        private void HomeViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(HomeViewModel.CanInstall)) CanExecuteChanged?.Invoke(sender, e);
        }
    }
}
