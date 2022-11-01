using System.Windows;
using CCDModInstaller.WPF.HostBuilders;
using CCDModInstaller.WPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace CCDModInstaller.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IHost _host;

        public MainWindow()
        {
            _host = CreateHostBuilder().Build();
            DataContext = _host.Services.GetRequiredService<MainViewModel>();
            InitializeComponent();
        }

        private IHostBuilder CreateHostBuilder(string[] args = null)
        {
            return Host.CreateDefaultBuilder(args)
                       .AddViewModels()
                       .AddStates();
        }
    }
}
