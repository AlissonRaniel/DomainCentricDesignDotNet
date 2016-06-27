[assembly: WebActivator.PreApplicationStartMethod(typeof(ProjetoDDD.Presentation.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(ProjetoDDD.Presentation.App_Start.NinjectWebCommon), "Stop")]

namespace ProjetoDDD.Presentation.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using projetoDDD.Application.Interfaces;
    using projetoDDD.Application.Services;
    using Domain.Interfaces.Service;
    using Domain.Services.Service;
    using Domain.Interfaces.Repository;
    using Infra.Data.Repositories;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
            
            RegisterServices(kernel);
            return kernel;
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IAppClienteService>().To<AppClienteService>();

            kernel.Bind<IClienteService>().To<ClienteService>();

            kernel.Bind<IClienteRepository>().To<ClienteRepository>();

            kernel.Bind<IAppFornecedorService>().To<AppFornecedorService>();

            kernel.Bind<IFornecedorService>().To<FornecedorService>();

            kernel.Bind<IFornecedorRepository>().To<FornecedorRepository>();

            kernel.Bind<IPratoService>().To<PratoService>();

            kernel.Bind<IPratoRepository>().To<PratoRepository>();
        }        
    }
}
