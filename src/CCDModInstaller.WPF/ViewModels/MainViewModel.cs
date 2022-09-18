using CCDModInstaller.WPF.States.Navigators;

namespace CCDModInstaller.WPF.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        private readonly INavigator _navigator;

        public MainViewModel(INavigator navigator) 
        {
            _navigator = navigator;
            _navigator.ViewModelChanged += OnCurrentViewChanged;
        }

        public ViewModelBase CurrentView => _navigator.CurrentViewModel;

        private void OnCurrentViewChanged()
        {
            OnPropertyChanged(nameof(CurrentView));
        }
    }
}
