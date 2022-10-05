using CCDModInstaller.WPF.States.Navigators;
using System;

namespace CCDModInstaller.WPF.ViewModels.Factories
{
    class FactoryViewModel : IFactoryViewModel
    {
        private readonly HomeViewModel _homeViewModel;

        public FactoryViewModel(HomeViewModel homeViewModel)
        {
            _homeViewModel = homeViewModel;
        }

        public ViewModelBase CreateViewModel(ViewType viewType)
        {
            return viewType switch 
            {
                ViewType.Home => _homeViewModel,
                _ => throw new ArgumentException()
            };
        }
    }
}
