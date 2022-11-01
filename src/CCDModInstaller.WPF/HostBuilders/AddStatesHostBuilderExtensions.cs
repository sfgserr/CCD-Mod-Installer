using CCDModInstaller.WPF.States.DialogServices;
using CCDModInstaller.WPF.States.Navigators;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace CCDModInstaller.WPF.HostBuilders
{
    public static class AddStatesHostBuilderExtensions
    {
        public static IHostBuilder AddStates(this IHostBuilder host)
        {
            host.ConfigureServices((context, services) =>
            {
                services.AddSingleton<IDialogService, DialogService>();
                services.AddSingleton<INavigator, Navigator>();
            });

            return host;
        }
    }
}
