using CCDModInstaller.WPF.States.Navigators;
using CCDModInstaller.WPF.ViewModels.Factories;
using System;
using System.Windows.Input;

namespace CCDModInstaller.WPF.Commands
{
    class UpdateViewCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly IFactoryViewModel _factoryViewModel;
        private readonly INavigator _navigator;

        public UpdateViewCommand(IFactoryViewModel factoryViewModel, INavigator navigator)
        {
            _factoryViewModel = factoryViewModel;
            _navigator = navigator;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            if (parameter is ViewType viewType)
            {
                _navigator.CurrentViewModel = _factoryViewModel.CreateViewModel(viewType);
            }
        }
    }
}
