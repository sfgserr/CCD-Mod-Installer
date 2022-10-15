using CCDModInstaller.WPF.States.DialogServices;
using CCDModInstaller.WPF.States.Navigators;
using CCDModInstaller.WPF.ViewModels;
using CCDModInstaller.WPF.ViewModels.Factories;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.Win32;
using System.Windows;
using CCDModInstaller.WPF.States.Archiver;
using CCDModInstaller.WPF.States.PlayerCarsServices;

namespace CCDModInstaller.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            IArchiver archiver = new Archiver();
            IDialogService dialogService = new DialogService(new CommonOpenFileDialog(), new OpenFileDialog());
            HomeViewModel home = new HomeViewModel(dialogService, new PlayerCarService(), archiver);
            IFactoryViewModel factory = new FactoryViewModel(home);
            DataContext = new MainViewModel(new Navigator(), factory);
            InitializeComponent();
        }
    }
}
