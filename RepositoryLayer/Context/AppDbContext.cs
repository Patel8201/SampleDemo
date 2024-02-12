using EntityLayer.WebApplication.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace RepositoryLayer.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public AppDbContext()
        {
        }
        public DbSet<Home> homes { get; set; }
        public DbSet<RequestAccess> requestAccess { get; set; }
        public DbSet<Blog> blog { get; set; }
        public DbSet<Event> events { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
