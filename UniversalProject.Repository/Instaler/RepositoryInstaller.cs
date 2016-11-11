using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using UniversalProject.DAO;
using UniversalProject.Repository.Base;

namespace UniversalProject.Repository.Instaler
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                    .InSameNamespaceAs<UserRepository>().WithServices().WithServiceDefaultInterfaces()
                    .LifestylePerWebRequest());
            container.Register(Component.For<IDbContextProvider>().ImplementedBy<DbContextProvider>().LifestylePerWebRequest());
            container.Register(Component.For<ProjectDbContext>().LifestylePerWebRequest());
        }
    }
}
