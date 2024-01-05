using DeliveryApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryApi.Context
{
    public class DeliveryContext : DbContext
    {
        public DeliveryContext(DbContextOptions<DeliveryContext> options) : base(options)
        {
            
        }

        public DbSet<Store> Stores { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
