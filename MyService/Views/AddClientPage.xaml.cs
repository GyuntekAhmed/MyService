namespace MyService.Views;

using MyService.Models;

public partial class AddClientPage : ContentPage
{
	public AddClientPage()
	{
		InitializeComponent();
	}

    private void clientCtrl_OnSave(object sender, EventArgs e)
    {
        ClientRepository.AddClient(new Models.Client()
        {
            Name = clientCtrl.Name,
            PhoneNumber = clientCtrl.PhoneNumber,
            RegistrationNumber = clientCtrl.RegistrationNumber,
            Brand = clientCtrl.Brand,
            Model = clientCtrl.Model,
            Assembly = clientCtrl.Assembly,
            Disassembly = clientCtrl.Disassembly,
            Rust = clientCtrl.Rust,
            Silicone = clientCtrl.Silicone,
            Work = clientCtrl.Work,
            Molding = clientCtrl.Molding,
            Consumables = clientCtrl.Consumables,
            Description = clientCtrl.Description,
            Photo = (clientCtrl.PhotoSource as StreamImageSource)?.Stream.ReadFully()
        });

        Shell.Current.GoToAsync($"//{nameof(ClientsPage)}");
    }

    private void clientCtrl_OnCancel(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(ClientsPage)}");
    }

    private void clientCtrl_OnError(object sender, string e)
    {
        DisplayAlert("Error", e, "OK");
    }
}