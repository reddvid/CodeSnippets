private void OnNavigated(object sender, NavigationEventArgs e)
{
  // Each time a navigation event occurs, update the Back button's visibility
  SystemNavigationManager.GetForCurrentView ().AppViewBackButtonVisibility =
  ((Frame) sender).CanGoBack ?
  AppViewBackButtonVisibility.Visible :
  AppViewBackButtonVisibility.Collapsed;
}

private void OnBackRequested(object sender, BackRequestedEventArgs e)
{
  Frame rootFrame =Window.Current.ContentasFrame;

  if (rootFrame.CanGoBack)
  {
    e.Handled=true;
    rootFrame.GoBack ();
  }
}
