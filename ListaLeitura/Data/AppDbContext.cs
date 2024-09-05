using ListaLeitura.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaLeitura.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
        }

        public DbSet<ListaLeituraModel> ListaLeituras { get; set; }
    }
}
