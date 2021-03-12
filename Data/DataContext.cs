using dnc.Models;
using Microsoft.EntityFrameworkCore;

namespace dnc.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }        
        
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().Property(user => user.Role).HasDefaultValue("userBase");
        }
    }
}