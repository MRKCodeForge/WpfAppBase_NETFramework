using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WpfAppBaseDotNetFramework.ViewModels
{
	public class MainWindow_VM : ObservableRecipient
	{
		private bool _state;
		private bool _canChange;

		public bool State
		{
			get => _state;
			set
			{
				SetProperty(ref _state, value);
			}
		}

		public bool CanChange
		{
			get => _canChange;
			set
			{
				SetProperty(ref _canChange, value);
				ChangeStateCommand.NotifyCanExecuteChanged();
			}
		}

		public RelayCommand ChangeStateCommand { get; }

		public MainWindow_VM()
		{
			ChangeStateCommand = new(ChangeStateExecute, ChangeStateCanExecute);
		}

		private bool ChangeStateCanExecute() => _canChange;

		private void ChangeStateExecute()
		{
			State = !State;
		}
	}
}
