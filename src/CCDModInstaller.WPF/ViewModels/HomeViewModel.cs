
namespace CCDModInstaller.WPF.ViewModels
{
    class HomeViewModel : ViewModelBase
    {
        private string _path;

        public string Path
        {
            get => _path;
            set => Set(ref _path, value);
        }

    }
}
