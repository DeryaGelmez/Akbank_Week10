using Microsoft.EntityFrameworkCore;
using System.Reflection;
using YetgenAkbankJump.Domain.Entities;
using YetgenAkbankJump.Domain.Identity;
using YetGenAkbankJump.Persistence.Configurations;

namespace YetGenAkbankJump.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public object Categories { get; set; }
        public object Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }


    }
}
