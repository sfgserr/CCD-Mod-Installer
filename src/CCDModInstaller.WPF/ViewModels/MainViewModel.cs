using CCDModInstaller.WPF.Commands;
using CCDModInstaller.WPF.States.Navigators;
using CCDModInstaller.WPF.ViewModels.Factories;
using System.Windows.Input;

namespace CCDModInstaller.WPF.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private readonly INavigator _navigator;
        private readonly IFactoryViewModel _factory;

        public MainViewModel(INavigator navigator, IFactoryViewModel factory) 
        {
            _factory = factory;
            _navigator = navigator;
            _navigator.ViewModelChanged += OnCurrentViewChanged;

            ShutDownCommand = new ShutDownCommand();
            UpdateViewCommand = new UpdateViewCommand(_factory, _navigator);
            UpdateViewCommand.Execute(ViewType.Home);
        }

        public ViewModelBase CurrentView => _navigator.CurrentViewModel;

        public ICommand UpdateViewCommand { get; }

        public ICommand ShutDownCommand { get; }

        private void OnCurrentViewChanged()
        {
            OnPropertyChanged(nameof(CurrentView));
        }
    }
}
