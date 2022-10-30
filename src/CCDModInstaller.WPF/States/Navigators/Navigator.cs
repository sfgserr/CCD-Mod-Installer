using CCDModInstaller.WPF.ViewModels;
using System;


namespace CCDModInstaller.WPF.States.Navigators
{
    class Navigator : INavigator
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set => Set(ref _currentViewModel, ref value);
        }

        private bool Set(ref ViewModelBase currentView, ref ViewModelBase nextView)
        {
            if(Equals(currentView, nextView)) return false;
            currentView = nextView;
            ViewModelChanged?.Invoke();
            return true;
        }

        public event Action ViewModelChanged;
    }
}
