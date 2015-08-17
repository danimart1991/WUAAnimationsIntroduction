namespace AnimationsIntroduction.WUA
{
	using Windows.UI.Xaml.Navigation;
	using Windows.UI.Xaml;
	using ThemeAnimations;
	using Transitions;

	public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationCacheMode = NavigationCacheMode.Required;
        }

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(AddDeleteThemeTransitionPage));
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(ContentThemeTransitionPage));
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(EdgeUIThemeTransitionPage));
		}

		private void Button_Click_4(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(EntranceThemeTransitionPage));
		}

		private void Button_Click_5(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(PaneThemeTransitionPage));
		}

		private void Button_Click_6(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(PopupThemeTransitionPage));
		}

		private void Button_Click_7(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(ReorderThemeTransitionPage));
		}

		private void Button_Click_8(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(RepositionThemeTransitionPage));
		}

		private void Button_Click_9(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(DragItemThemeAnimationPage));
		}

		private void Button_Click_10(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(DragOverThemeAnimationPage));
		}

		private void Button_Click_11(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(DropTargetItemThemeAnimationPage));
		}

		private void Button_Click_12(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(FadeInAndOutThemeAnimationPage));
		}

		private void Button_Click_13(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(PointerDownAndUpThemeAnimationPage));
		}

		private void Button_Click_14(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(PopInAndOutThemeAnimationPage));
		}

		private void Button_Click_15(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(RepositionThemeAnimationPage));
		}

		private void Button_Click_16(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(SplitCloseAndOpenThemeAnimationPage));
		}
		
		private void Button_Click_17(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(SwipeBackAndHintThemeAnimationPage));
		}
    }
}
