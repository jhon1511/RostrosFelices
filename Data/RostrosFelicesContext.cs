using Microsoft.EntityFrameworkCore;
using RostrosFelices.Models;

namespace RostrosFelices.Data
{
    public class RostrosFelicesContext : DbContext
    {
		public RostrosFelicesContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<Cliente> Clientes { get; set; } 
        public DbSet<Servicio> Servicios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=Rostros_Felices; Trusted_Connection= True;");
        }
    }
}
