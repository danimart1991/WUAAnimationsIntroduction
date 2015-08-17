namespace AnimationsIntroduction.WUA.Transitions
{
	using System;
	using System.Collections.Generic;
	using Windows.UI;
	using Windows.UI.Xaml;
	using Windows.UI.Xaml.Media;
	using Windows.UI.Xaml.Shapes;

	public sealed partial class ContentThemeTransitionPage
	{
		private readonly Random _random;

		public ContentThemeTransitionPage()
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
				var newItems = new List<UIElement>();

				for (var i = 0; i < _random.Next(1, 20); i++)
				{
					newItems.Add(new Rectangle
					{
						Margin = new Thickness(10),
						Width = 50,
						Height = 50,
						Fill = new SolidColorBrush(new Color
						{
							A = 255,
							B = Convert.ToByte(_random.Next(255)),
							G = Convert.ToByte(_random.Next(255)),
							R = Convert.ToByte(_random.Next(255))
						})
					});
				}

				ItemsControl.ItemsSource = newItems;
			}
		}
	}
}
