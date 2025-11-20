using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace WpfAppBaseDotNetFramework.Managers
{
	class ApplicationManager : ObservableRecipient
	{
		private static readonly Lazy<ApplicationManager> _lazyInstance =
			new(() => new());

		public static ApplicationManager Instance => _lazyInstance.Value;

		public IServiceProvider ServiceProvider { get; }

		private ApplicationManager()
		{
			ServiceProvider = new ServiceCollection()
				.AddSingleton<IExampleManager, ExampleManager>()
				.BuildServiceProvider();
		}
	}
}
