namespace MyService.Models
{
    public class ClientRepository
    {
        public static List<Client> clients = new List<Client>();

        public static List<Client> GetClients() => clients;

        public static Client? GetClientById(int id)
        {
            var currentClient = clients.FirstOrDefault(c => c.ClientId == id);

            if (currentClient != null)
            {
                return new Client
                {
                    ClientId = currentClient.ClientId,
                    Name = currentClient.Name,
                    PhoneNumber = currentClient.PhoneNumber,
                    RegistrationNumber = currentClient.RegistrationNumber,
                    Brand = currentClient.Brand,
                    Model = currentClient.Model,
                    Assembly = currentClient.Assembly,
                    Disassembly = currentClient.Disassembly,
                    Rust = currentClient.Rust,
                    Silicone = currentClient.Silicone,
                    Work = currentClient.Work,
                    Molding = currentClient.Molding,
                    Consumables = currentClient.Consumables,
                    Description = currentClient.Description,
                    Photo = currentClient.Photo,
                };
            }

            return null;
        }

        public static void UpdateClient(int clientId, Client client)
        {
            if (clientId != client.ClientId)
            {
                return;
            }

            var clientToUpdate = clients.FirstOrDefault(c => c.ClientId == clientId);

            if (clientToUpdate != null)
            {
                clientToUpdate.Name = client.Name;
                clientToUpdate.PhoneNumber = client.PhoneNumber;
                clientToUpdate.RegistrationNumber = client.RegistrationNumber;
                clientToUpdate.Brand = client.Brand;
                clientToUpdate.Model = client.Model;
                clientToUpdate.Assembly = client.Assembly;
                clientToUpdate.Disassembly = client.Disassembly;
                clientToUpdate.Rust = client.Rust;
                clientToUpdate.Silicone = client.Silicone;
                clientToUpdate.Work = client.Work;
                clientToUpdate.Molding = client.Molding;
                clientToUpdate.Consumables = client.Consumables;
                clientToUpdate.Description = client.Description;
                clientToUpdate.Photo = client.Photo;
            }
        }

        public static void AddClient(Client client)
        {
            if (clients.Count == 0)
            {
                client.ClientId = 1;
            }
            else
            {
                var maxId = clients.Max(c => c.ClientId);
                client.ClientId = maxId + 1;
            }

            clients.Add(client);
        }

        public static void DeleteClient(int clientId)
        {
            var client = clients.FirstOrDefault(c => c.ClientId == clientId);

            if (client != null)
            {
                clients.Remove(client);
            }
        }

        public static List<Client> SearchClient(string filterText)
        {
            filterText = filterText?.Trim() ?? "";

            return clients
                .Where(c =>
                    (!string.IsNullOrWhiteSpace(c.Name) && c.Name.StartsWith(filterText, StringComparison.OrdinalIgnoreCase)) ||
                    (!string.IsNullOrWhiteSpace(c.PhoneNumber) && c.PhoneNumber.StartsWith(filterText, StringComparison.OrdinalIgnoreCase)) ||
                    (!string.IsNullOrWhiteSpace(c.RegistrationNumber) && c.RegistrationNumber.StartsWith(filterText, StringComparison.OrdinalIgnoreCase)) ||
                    (!string.IsNullOrWhiteSpace(c.Brand) && c.Brand.StartsWith(filterText, StringComparison.OrdinalIgnoreCase)) ||
                    (!string.IsNullOrWhiteSpace(c.Model) && c.Model.StartsWith(filterText, StringComparison.OrdinalIgnoreCase)))
                .ToList();
        }

    }
}
