using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using UniversalProject.DataModel;
using UniversalProject.DAO.Migrations;

namespace UniversalProject.ADO
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext()
            : base("Name = UniversalProject")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProjectDbContext, Configuration>());
        }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
