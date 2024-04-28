namespace MyService.Views;

using System.Collections.ObjectModel;

using MyService.Models;

public partial class ClientsPage : ContentPage
{
	public ClientsPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        SearchBar.Text = string.Empty;
        LoadClients();
    }

    private async void listClients_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (listClients.SelectedItem != null)
        {
            await Shell
                .Current
                .GoToAsync($"{nameof(EditClientPage)}?Id={((Contact)listClients.SelectedItem).Id}");
        }
    }

    private void listClients_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        listClients.SelectedItem = null;
    }

    private void BtnAdd_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddClientPage));
    }

    private void Delete_Clicked(object sender, EventArgs e)
    {
        var menuItem = sender as MenuItem;
        var client = menuItem!.CommandParameter as Client;

        ClientRepository.DeleteClient(client!.ClientId);

        LoadClients();
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        var clients = new ObservableCollection<Client>
            (ClientRepository.SearchClient(((SearchBar)sender).Text));
        listClients.ItemsSource = clients;
    }

    private void LoadClients()
    {
        var clients = new ObservableCollection<Client>(ClientRepository.GetClients());

        listClients.ItemsSource = clients;
    }
}