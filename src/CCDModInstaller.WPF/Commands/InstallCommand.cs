using CCDModInstaller.WPF.States.Archiver;
using CCDModInstaller.WPF.ViewModels;
using System;
using System.Windows.Input;

namespace CCDModInstaller.WPF.Commands
{
    class InstallCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly IArchiver _archiver;
        private readonly HomeViewModel _home;

        public InstallCommand(IArchiver archiver, HomeViewModel home)
        {
            _archiver = archiver;
            _home = home;

            _home.PropertyChanged += HomeViewModel_PropertyChanged;
        }

        public bool CanExecute(object? parameter)
        {
            return _home.CanInstall;
        }

        public void Execute(object? parameter)
        {
            _archiver.Unzip(_home.FilePath);
        }

        private void HomeViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(HomeViewModel.CanInstall)) CanExecuteChanged?.Invoke(sender, e);
        }
    }
}
