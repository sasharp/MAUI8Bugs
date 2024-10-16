namespace MAUI8Bugs
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute("subpage", typeof(SubPage));
            InitializeComponent();
        }

        private void Shell_Navigated(object sender, ShellNavigatedEventArgs e)
        {

        }

        private void Shell_Navigating(object sender, ShellNavigatingEventArgs e)
        {

        }

        private void Shell_NavigatedFrom(object sender, NavigatedFromEventArgs e)
        {

        }

        private void Shell_NavigatingFrom(object sender, NavigatingFromEventArgs e)
        {

        }

        private void Shell_NavigatedTo(object sender, NavigatedToEventArgs e)
        {

        }
    }
}
