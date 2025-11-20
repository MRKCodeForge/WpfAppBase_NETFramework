using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfAppBaseDotNetFramework.ViewModels
{
	public partial class SecondaryWindow_VM : ObservableRecipient
	{
		private string _message;

		public string Message
		{
			get => _message;
			set => SetProperty(ref _message, value);
		}
	}
}
