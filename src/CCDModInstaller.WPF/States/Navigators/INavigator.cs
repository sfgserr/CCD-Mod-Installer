using CCDModInstaller.WPF.ViewModels;
using System;


namespace CCDModInstaller.WPF.States.Navigators
{
    interface INavigator
    {
        ViewModelBase CurrentViewModel { get; set; }

        event Action ViewModelChanged;
    }
}
