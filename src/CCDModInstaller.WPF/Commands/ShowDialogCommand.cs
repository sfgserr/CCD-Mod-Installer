using CCDModInstaller.WPF.States.DialogService;
using CCDModInstaller.WPF.ViewModels;
using System;
using System.Windows.Input;

namespace CCDModInstaller.WPF.Commands
{
    class ShowDialogCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly IDialogService _dialogService;
        private readonly HomeViewModel _home;

        public ShowDialogCommand(IDialogService dialogService, HomeViewModel home)
        {
            _dialogService = dialogService;
            _home = home;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _home.Path = _dialogService.SelectFolder();
        }
    }
}
