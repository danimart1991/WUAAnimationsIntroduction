namespace AnimationsIntroduction.WUA.ThemeAnimations
{
	using Windows.UI.Xaml;

	public sealed partial class SplitCloseAndOpenThemeAnimationPage
	{

		public SplitCloseAndOpenThemeAnimationPage()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Frame.GoBack();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			MyStoryboard.Begin();
			ContentPopup.IsOpen = false;
		}
		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			MyStoryboard2.Begin();
			ContentPopup.IsOpen = true;
		}
	}
}
