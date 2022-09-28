using CCDModInstaller.WPF.States.Navigators;


namespace CCDModInstaller.WPF.ViewModels.Factories
{
    interface IFactoryViewModel
    {
        ViewModelBase CreateViewModel(ViewType viewType);
    }
}
