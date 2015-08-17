namespace AnimationsIntroduction.WUA.Transitions
{
	using System;
	using System.Linq;
	using Windows.UI;
	using Windows.UI.Xaml;
	using Windows.UI.Xaml.Media;
	using Windows.UI.Xaml.Shapes;

	public sealed partial class AddDeleteThemeTransitionPage
	{
		private readonly Random _random;

		public AddDeleteThemeTransitionPage()
		{
			InitializeComponent();

			_random = new Random();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Frame.GoBack();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			if (ItemsControl != null && ItemsControl.Items != null)
			{
				ItemsControl.Items.Add(new Rectangle
				{
					Margin = new Thickness(10),
					Width = 50,
					Height = 50,
					Fill = new SolidColorBrush(new Color
					{
						A=255, 
						B = Convert.ToByte(_random.Next(255)),
						G = Convert.ToByte(_random.Next(255)),
						R = Convert.ToByte(_random.Next(255))
					})
				});
			}
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			if (ItemsControl != null && ItemsControl.Items != null && ItemsControl.Items.Any())
			{
				ItemsControl.Items.RemoveAt(0);
			}
		}
	}
}
