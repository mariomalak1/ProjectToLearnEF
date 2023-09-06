using LearnEFByProject.DataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnEFByProject.DataBase;

public class DataBaseContext : DbContext
{
    public DbSet<Order> Orders { get; set; } = null;
    public DbSet<Customer> Customers { get; set; } = null;
    public DbSet<Product> Product { get; set; } = null;
    public DbSet<Cart> Cart { get; set; } = null;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1T54BKJ\MSSQLSERVER02;Initial Catalog=LearnEFByProject;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
}
