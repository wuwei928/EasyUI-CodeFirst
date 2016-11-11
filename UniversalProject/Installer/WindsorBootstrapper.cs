using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using UniversalProject.Logic.Installer;
using UniversalProject.Repository.Instaler;

namespace UniversalProject.Installer
{
    public static class WindsorBootstrapper
    {
        private static IWindsorContainer _container;
        public static void Initialize()
        {
            _container = new WindsorContainer();
            _container.Install(FromAssembly.This(),
                FromAssembly.Containing<LogicInstaller>(),
                FromAssembly.Containing<RepositoryInstaller>());
            _container.Register(Component.For<IWindsorContainer>().Instance(_container).LifestyleSingleton());
            var controllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }

        public static IWindsorContainer GetContainer()
        {
            return _container;
        }
    }
}