namespace AnimationsIntroduction.WUA.Transitions
{
	using Windows.UI.Xaml;

	public sealed partial class ReorderThemeTransitionPage
	{

		public ReorderThemeTransitionPage()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Frame.GoBack();
		}
	}
}
