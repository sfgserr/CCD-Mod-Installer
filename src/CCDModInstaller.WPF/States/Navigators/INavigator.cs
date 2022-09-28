using CCDModInstaller.WPF.ViewModels;
using System;


namespace CCDModInstaller.WPF.States.Navigators
{
    public enum ViewType
    {
        Home
    }

    interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }

        event Action ViewModelChanged;
    }
}
