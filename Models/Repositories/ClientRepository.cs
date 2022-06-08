using Ap2_1.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ap2_1.Models.Repositories;

public class ClientRepository : IClientRepository
{
    public ClientRepository(DataContext dataContext)
    {
        DataContext = dataContext;
    }

    private DataContext DataContext { get; }

    public Client GetById(int id)
    {
        return DataContext.Client.SingleOrDefault(client => client.ClientId == id);
    }

    public List<Client> GetAll()
    {
        return DataContext.Client.Include(o => o.billings).ToList();
    }

    public void Insert(Client client)
    {
        DataContext.Client.Add(client);
        DataContext.SaveChanges();
    }

    public void Update(Client client)
    {
        DataContext.Client.Update(client);
        DataContext.SaveChanges();
    }

    public void Delete(int id)
    {
        var clienteToBeDeleted = GetById(id);
        DataContext.Client.Remove(clienteToBeDeleted);
        DataContext.SaveChanges();
    }

    
}