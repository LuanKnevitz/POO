using Ap2_1.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ap2_1.Models.Repositories;

public class BillingRepository : IBillingRepository
{
    public BillingRepository(DataContext dataContext)
    {
        DataContext = dataContext;
    }

    private DataContext DataContext { get; }
    
    public Billing GetById(int id)
    {   
        return DataContext.Billings.SingleOrDefault(billing => billing.BillingId == id);
    }

    public List<Billing> GetAll()
    {
        return DataContext.Billings.ToList();
    }

    public void Insert(Billing billing)
    {
        DataContext.Billings.Add(billing);
        DataContext.SaveChanges();
    }

    public void Update(Billing billing)
    {
        DataContext.Billings.Update(billing);
        DataContext.SaveChanges();
    }

    public void Delete(int id)
    {    var billingToBeDeleted = GetById(id);
        DataContext.Billings.Remove(billingToBeDeleted);
        DataContext.SaveChanges();
    }
}