namespace AnimationsIntroduction.WUA.Transitions
{
	using Windows.UI.Xaml;

	public sealed partial class EntranceThemeTransitionPage
	{

		public EntranceThemeTransitionPage()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Frame.GoBack();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			TextBlock.Visibility = Visibility.Visible;
		}
	}
}
