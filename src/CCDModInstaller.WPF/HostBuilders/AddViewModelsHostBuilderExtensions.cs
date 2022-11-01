using CCDModInstaller.WPF.ViewModels;
using CCDModInstaller.WPF.ViewModels.Factories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace CCDModInstaller.WPF.HostBuilders
{
    public static class AddViewModelsHostBuilderExtensions
    {
        public static IHostBuilder AddViewModels(this IHostBuilder host)
        {
            host.ConfigureServices((context, services) =>
            {
                services.AddScoped<MainViewModel>();
                services.AddScoped<HomeViewModel>();
                services.AddScoped<IFactoryViewModel, FactoryViewModel>();
            });

            return host;
        }
    }
}
