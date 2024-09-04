using Microsoft.EntityFrameworkCore;
using parcial_uno.Shared.Entities;

namespace parcial_uno.API.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Machinery> Machines { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Machinery>().HasIndex(x => x.Code).IsUnique();
        }
    }
}
