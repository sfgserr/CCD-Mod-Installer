using CCDModInstaller.WPF.States.DialogService;
using CCDModInstaller.WPF.States.Navigators;
using CCDModInstaller.WPF.ViewModels;
using CCDModInstaller.WPF.ViewModels.Factories;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows;


namespace CCDModInstaller.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            IDialogService dialogService = new DialogService(new CommonOpenFileDialog());
            HomeViewModel home = new HomeViewModel(dialogService);
            IFactoryViewModel factory = new FactoryViewModel(home);
            DataContext = new MainViewModel(new Navigator(), factory);
            InitializeComponent();
        }
    }
}
