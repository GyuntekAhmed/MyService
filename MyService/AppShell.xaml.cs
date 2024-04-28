namespace MyService
{
    using MyService.Views;

    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ClientsPage), typeof(ClientsPage));
            Routing.RegisterRoute(nameof(EditClientPage), typeof(EditClientPage));
            Routing.RegisterRoute(nameof(AddClientPage), typeof(AddClientPage));
        }
    }
}
