namespace AnimationsIntroduction.WUA.Transitions
{
	using System;
	using Windows.UI.Xaml;

	public sealed partial class RepositionThemeTransitionPage
	{
		private readonly Random _random;

		public RepositionThemeTransitionPage()
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
			Button.Margin = new Thickness(_random.Next(-200, 200), _random.Next(-200, 200), _random.Next(-200, 200), _random.Next(-200, 200));
		}
	}
}
