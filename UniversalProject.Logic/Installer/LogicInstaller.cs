using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;

namespace UniversalProject.Logic.Installer
{
    public class LogicInstaller:IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.FromThisAssembly()
                    .InSameNamespaceAs<UserLogic>()
                    .WithServiceAllInterfaces()
                    .LifestylePerWebRequest());
        }
    }
}
