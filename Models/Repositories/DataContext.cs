using Ap2_1.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ap2_1.Models.Repositories;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    public DbSet<Client> Client { get; set; }
    public DbSet<Billing> Billings { get; set; }
}