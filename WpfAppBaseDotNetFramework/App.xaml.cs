using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;
using WpfAppBaseDotNetFramework.ViewModels;
using WpfAppBaseDotNetFramework.Views;

namespace WpfAppBaseDotNetFramework
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public static IServiceProvider ServiceProvider { get; private set; }

		public App()
		{
			var host = Host.CreateDefaultBuilder().ConfigureServices(ConfigureServices).Build();
			ServiceProvider = host.Services;
		}

		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			var view = ServiceProvider.GetService<MainWindow>();
			view.Show();
		}

		private void ConfigureServices(HostBuilderContext context, IServiceCollection services)
		{
			services.AddSingleton<MainWindow>();
			services.AddSingleton<MainWindow_VM>();
			services.AddTransient<SecondaryWindow>();
			services.AddTransient<SecondaryWindow_VM>();
		}
	}
}
