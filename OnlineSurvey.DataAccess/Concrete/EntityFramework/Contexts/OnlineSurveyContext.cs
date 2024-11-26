using Microsoft.EntityFrameworkCore;
using OnlineSurvey.Core.Utilities.Configuration;
using OnlineSurvey.Entities.Concrete;
using System.Reflection;

namespace OnlineSurvey.DataAccess.Concrete.EntityFramework.Contexts
{
    public class OnlineSurveyContext : DbContext
    {
        public DbSet<Poll> Polls { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(CoreConfig.GetConnectionString("Default"));
        }
    }
}
