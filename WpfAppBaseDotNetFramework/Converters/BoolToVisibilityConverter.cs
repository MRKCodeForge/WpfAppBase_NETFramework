using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace WpfAppBaseDotNetFramework.Converters
{
	internal class BoolToVisibilityConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var val = (bool)value;

			if (parameter != null &&
				parameter.ToString() == "INVERT")
				val = !val;

			return val ? Visibility.Visible : Visibility.Collapsed;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
