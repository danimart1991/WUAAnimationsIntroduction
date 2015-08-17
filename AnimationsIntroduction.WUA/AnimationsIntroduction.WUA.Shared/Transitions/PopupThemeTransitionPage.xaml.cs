namespace AnimationsIntroduction.WUA.Transitions
{
	using Windows.UI.Xaml;

	public sealed partial class PopupThemeTransitionPage
	{

		public PopupThemeTransitionPage()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Frame.GoBack();
		}
	}
}
