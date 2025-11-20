using Microsoft.Extensions.DependencyInjection;

namespace WpfAppBaseDotNetFramework.ViewModels
{
	public class ViewModelLocator
	{
		public MainWindow_VM MainWindow_VM => App.ServiceProvider.GetRequiredService<MainWindow_VM>();
		public SecondaryWindow_VM SecondaryWindow_VM => App.ServiceProvider.GetRequiredService<SecondaryWindow_VM>();
	}
}
