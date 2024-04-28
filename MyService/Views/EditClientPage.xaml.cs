namespace MyService.Views;

using MyService.Models;

[QueryProperty(nameof(ClientId), "Id")]
public partial class EditClientPage : ContentPage
{
	private Client client;

	public EditClientPage()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    public string ClientId
    {
        set
        {
            client = ClientRepository.GetClientById(int.Parse(value));
            if (client != null)
            {
                clientCtrl.Name = client.Name;
                clientCtrl.PhoneNumber = client.PhoneNumber;
                clientCtrl.RegistrationNumber = client.RegistrationNumber;
                clientCtrl.Brand = client.Brand;
                clientCtrl.Model = client.Model;
                clientCtrl.Assembly = client.Assembly;
                clientCtrl.Disassembly = client.Disassembly;
                clientCtrl.Rust = client.Rust;
                clientCtrl.Silicone = client.Silicone;
                clientCtrl.Work = client.Work;
                clientCtrl.Molding = client.Molding;
                clientCtrl.Consumables = client.Consumables;
                clientCtrl.Description = client.Description;
                clientCtrl.Photo = client.Photo!;
            }
        }
    }

    private void btnUpdate_Clicked(object sender, EventArgs e)
    {
        client.Name = clientCtrl.Name;
        client.PhoneNumber = clientCtrl.PhoneNumber;
        client.RegistrationNumber = clientCtrl.RegistrationNumber;
        client.Brand = clientCtrl.Brand;
        client.Model = clientCtrl.Model;
        client.Assembly = clientCtrl.Assembly;
        client.Disassembly = clientCtrl.Disassembly;
        client.Rust = clientCtrl.Rust;
        client.Silicone = clientCtrl.Silicone;
        client.Work = clientCtrl.Work;
        client.Molding = clientCtrl.Molding;
        client.Consumables = clientCtrl.Consumables;
        client.Description = clientCtrl.Description;
        client.Photo = clientCtrl.Photo;

        ClientRepository.UpdateClient(client.ClientId, client);
        Shell.Current.GoToAsync("..");
    }

    private void clientCtrl_OnError(object sender, string e)
    {
        DisplayAlert("Error", e, "OK");
    }
}