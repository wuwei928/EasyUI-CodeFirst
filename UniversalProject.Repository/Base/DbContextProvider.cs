using Castle.Windsor;
using System.Data.Entity;
using UniversalProject.DAO;

namespace UniversalProject.Repository.Base
{
    public class DbContextProvider : IDbContextProvider
    {
        private readonly IWindsorContainer _container;

        public DbContextProvider(IWindsorContainer container)
        {
            _container = container;
        }

        public ProjectDbContext CurrentDbContext()
        {
            return _container.Resolve<ProjectDbContext>();
        }
    }
}
