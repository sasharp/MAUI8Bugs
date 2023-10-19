namespace MAUI8Bugs
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute("subpage", typeof(SubPage));
            InitializeComponent();
        }
    }
}
