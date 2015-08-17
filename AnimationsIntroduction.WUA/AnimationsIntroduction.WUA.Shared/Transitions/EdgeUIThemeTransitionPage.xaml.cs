namespace AnimationsIntroduction.WUA.Transitions
{
	using Windows.UI.Xaml;

	public sealed partial class EdgeUIThemeTransitionPage
	{

		public EdgeUIThemeTransitionPage()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Frame.GoBack();
		}
	}
}
