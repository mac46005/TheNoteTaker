using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TNT_WPF.MVVM.ViewModels;

namespace TNT_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IServiceProvider serviceProvider;
        protected override void OnStartup(StartupEventArgs e)
        {
            serviceProvider = CreateServiceProvider();

            base.OnStartup(e);
        }


        private IServiceProvider CreateServiceProvider()
        {
            var services = new ServiceCollection();
            services.AddScoped<IServiceProvider, IServiceProvider>();
            services.AddScoped<MainViewModel>();




            return services.BuildServiceProvider();
        }

    }
}
